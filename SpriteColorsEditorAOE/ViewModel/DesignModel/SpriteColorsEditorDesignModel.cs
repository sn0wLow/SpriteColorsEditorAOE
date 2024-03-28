using System.Collections.ObjectModel;

namespace SpriteColorsEditorAOE
{
    public class SpriteColorsEditorDesignModel
    {

        public ObservableCollection<PlayerColorItemDesignModel> PlayerColors { get; private set; } = new();

        public SpriteColorsEditorDesignModel()
        {
            var gaia = new PlayerColorItemDesignModel()
            {
                PlayerName = "Gaia",
                OutlineColors = new OutlineColors() { FloatRGBA = new FloatRGBA() { R = 10 / 255.0f, G = 150 / 255.0f, B = 150 / 255.0f, A = 1 } },
                TeamColors = new TeamColors() { FloatRGBA = new FloatRGBA() { R = 20 / 255.0f, G = 200 / 255.0f, B = 200 / 255.0f, A = 1 } },
            };

            var p1 = new PlayerColorItemDesignModel()
            {
                PlayerName = "Player 1",
                OutlineColors = new OutlineColors() { FloatRGBA = new FloatRGBA() },
                TeamColors = new TeamColors() { FloatRGBA = new FloatRGBA() }
            };

            var p2 = new PlayerColorItemDesignModel()
            {
                PlayerName = "Player 2",
                OutlineColors = new OutlineColors() { FloatRGBA = new FloatRGBA() },
                TeamColors = new TeamColors() { FloatRGBA = new FloatRGBA() }
            };

            PlayerColors.Add(gaia);
            PlayerColors.Add(p1);
            PlayerColors.Add(p2);
        }

        //private readonly string designJson;
        //public bool HasPlayerColorsLoaded { get; set; } = false;
        //public SpriteColors? SpriteColors { get; private set; }
        //public ObservableCollection<PlayerColorItemDesignModel> PlayerColors { get; private set; } = new();
        //public SpriteColorsEditorDesignModel()
        //{
        //    designJson =
        //        """
        //        {
        //        	"TeamColors": {
        //        		"Gaia": { "HexColor": { "argb": "ffffffff" } },
        //        		"Player 1": { "HexColor": { "argb": "ff0000ff" } },
        //        		"Player 2": { "HexColor": { "argb": "ffffdd73" } },
        //        		"Player 3": { "HexColor": { "argb": "ff00141e" } },
        //        		"Player 4": { "HexColor": { "argb": "ff4495ff" } },
        //        		"Player 8": { "HexColor": { "argb": "ff704300" } },
        //        		"Player 5": { "HexColor": { "argb": "ff91b1ff" } },
        //        		"Player 6": { "HexColor": { "argb": "ff36295a" } },
        //        		"Player 7": { "HexColor": { "argb": "ff636770" } }
        //        	},
        //        	"OutlineColors": {
        //                "Gaia": { "HexColor": { "argb": "ffffffff" } },
        //                "Player 1": { "HexColor": { "argb": "ff305db6" } },
        //                "Player 2": { "HexColor": { "argb": "ffffd24b" } },
        //                "Player 3": { "HexColor": { "argb": "ff002b4a" } },
        //                "Player 4": { "HexColor": { "argb": "ff00a0f3" } },
        //                "Player 8": { "HexColor": { "argb": "ff7d4a00" } },
        //                "Player 5": { "HexColor": { "argb": "ff97ceff" } },
        //                "Player 6": { "HexColor": { "argb": "ff850c79" } },
        //                "Player 7": { "HexColor": { "argb": "ff575757" } }
        //        	}
        //        }
        //        """;

        //    ParseSpriteColorsJsonAsync();
        //}

        //private async void ParseSpriteColorsJsonAsync()
        //{
        //    using var stringStream = new MemoryStream(Encoding.UTF8.GetBytes(designJson));

        //    var options = new JsonSerializerOptions
        //    {
        //        PropertyNameCaseInsensitive = true,
        //    };

        //    this.SpriteColors = await JsonSerializer.DeserializeAsync<SpriteColors>(stringStream, options);

        //    var playerColors = this.SpriteColors.TeamColors.Zip(this.SpriteColors.OutlineColors);

        //    foreach (var item in playerColors)
        //    {

        //        string hexFirst = item.First.Value.FloatRGBA.ARGB;
        //        string hexSecond = item.Second.Value.FloatRGBA.ARGB;

        //        int argbFirst = int.Parse(hexFirst, System.Globalization.NumberStyles.HexNumber);
        //        int argbSecond = int.Parse(hexSecond, System.Globalization.NumberStyles.HexNumber);

        //        item.First.Value.FloatRGBA.A = (argbFirst >> 24) & 0xFF;
        //        item.First.Value.FloatRGBA.R = (argbFirst >> 16) & 0xFF;
        //        item.First.Value.FloatRGBA.G = (argbFirst >> 8) & 0xFF;
        //        item.First.Value.FloatRGBA.B = argbFirst & 0xFF;

        //        item.Second.Value.FloatRGBA.A = (argbSecond >> 24) & 0xFF;
        //        item.Second.Value.FloatRGBA.R = (argbSecond >> 16) & 0xFF;
        //        item.Second.Value.FloatRGBA.G = (argbSecond >> 8) & 0xFF;
        //        item.Second.Value.FloatRGBA.B = argbSecond & 0xFF;

        //        var vm = new PlayerColorItemDesignModel()
        //        {
        //            TeamColorsVM = new TeamColorsItemViewModel() { PlayerName = item.First.Key, TeamColors = item.First.Value },
        //            OutlineColorsVM = new OutlineColorsItemViewModel() { PlayerName = item.Second.Key, OutlineColors = item.Second.Value },
        //        };

        //        //vm.TeamColorsVM.TeamColors.FloatRGBA.PropertyChanged += (sender, e) => 
        //        //{ vm.TeamColorsVM.OnPropertyChanged(nameof(vm.TeamColorsVM.TeamColors)); };

        //        //vm.OutlineColorsVM.OutlineColors.FloatRGBA.PropertyChanged += (sender, e) =>
        //        //{ vm.OutlineColorsVM.OnPropertyChanged(nameof(vm.OutlineColorsVM.OutlineColors)); };

        //        PlayerColors.Add(vm);
        //        HasPlayerColorsLoaded = false;
        //    }
        //}
    }
}
