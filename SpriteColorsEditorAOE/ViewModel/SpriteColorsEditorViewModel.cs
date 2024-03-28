using FracturedJson;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpriteColorsEditorAOE
{
    public class SpriteColorsEditorViewModel : BaseViewModel
    {
        private SpriteColors? _spriteColors;

        public bool HasSpriteColorsLoaded { get; private set; } = false;

        public bool IsParsingJson { get; private set; } = false;
        public bool IsBusy { get; private set; } = false;

        public ObservableCollection<PlayerColorItemViewModel> PlayerColors { get; private set; } = new();


        public async void DeserializeSpriteColorsJsonAsync(string pathToJsonFile)
        {
            await RunCommandAsync(() => IsParsingJson, async () =>
            {
                try
                {
                    using var streamReader = File.OpenRead(pathToJsonFile);

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };

                    _spriteColors = await JsonSerializer.DeserializeAsync<SpriteColors>(streamReader, options);

                    if (_spriteColors is null)
                    {

                        return;
                    }

                    var zippedSpriteColors = _spriteColors.TeamColors.Zip(_spriteColors.OutlineColors);

                    foreach (var spriteColor in zippedSpriteColors)
                    {
                        var teamColor = spriteColor.First.Value;
                        var outlineColor = spriteColor.Second.Value;
                        var playerName = spriteColor.First.Key;

                        var spriteColorItemVM = new PlayerColorItemViewModel(playerName, teamColor, outlineColor); 

                        PlayerColors.Add(spriteColorItemVM);
                    }

                    HasSpriteColorsLoaded = true;
                }

                catch (UnauthorizedAccessException ex)
                {
                    System.Windows.MessageBox.Show($"You do not have access to view this file:\n{ex.Message}",
                    "Opening spritecolors failed (Access Denied)",
                    System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                }
                catch (JsonException ex)
                {
                    System.Windows.MessageBox.Show($"File content is not valid JSON:\n{ex.Message}",
                    "Opening spritecolors failed (Parsing failed)",
                    System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show($"Unexpected Exception importing file:\n{ex.Message}", "Opening spritecolors failed",
                    System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                }
            });
        }

        public async void SerializeSpriteColorsJsonAsync(string jsonDestinationPath)
        {
            if (_spriteColors is null)
            {

                return;
            }

            await RunCommandAsync(() => IsBusy, async () =>
            {
                _spriteColors.TeamColors.Clear();
                _spriteColors.OutlineColors.Clear();

                foreach (var spriteColor in PlayerColors)
                {
                    _spriteColors.TeamColors.Add(spriteColor.PlayerName, new TeamColors() 
                    { 
                        FloatRGBA = new FloatRGBA () 
                        {
                            R = spriteColor.TeamColors.FloatRGBA.R,
                            G = spriteColor.TeamColors.FloatRGBA.G,
                            B = spriteColor.TeamColors.FloatRGBA.B,
                            A = spriteColor.TeamColors.FloatRGBA.A
                        } 
                    });
                    _spriteColors.OutlineColors.Add(spriteColor.PlayerName, new OutlineColors()
                    {
                        FloatRGBA = new FloatRGBA()
                        {
                            R = spriteColor.OutlineColors.FloatRGBA.R,
                            G = spriteColor.OutlineColors.FloatRGBA.G,
                            B = spriteColor.OutlineColors.FloatRGBA.B,
                            A = spriteColor.OutlineColors.FloatRGBA.A
                        }
                    });
                }

                var fracturedJsonOptions = new FracturedJsonOptions();

                var formatter = new Formatter()
                {
                    Options = new FracturedJsonOptions()
                    {
                        MaxTableRowComplexity = 1,
                        SimpleBracketPadding = true,
                        DontJustifyNumbers = false,
                    }
                };

                var output = formatter.Serialize(this._spriteColors, 0);
                var fileName = Path.GetFileName(jsonDestinationPath);

                try
                {
                    using var file = new StreamWriter(jsonDestinationPath);
                    await file.WriteAsync(output);

                    System.Windows.MessageBox.Show($"Successfully saved {fileName}", "Saving Successful",
                    System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);

                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show($"Could not save {fileName}:\n{ex.Message}", "Saving Failed",
                    System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                }

            });
        }

        public void Close()
        {
            HasSpriteColorsLoaded = false;
            PlayerColors.Clear();
        }
    }
}
