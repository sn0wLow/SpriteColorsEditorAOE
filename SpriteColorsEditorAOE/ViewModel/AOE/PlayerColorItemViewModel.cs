namespace SpriteColorsEditorAOE
{
    public class PlayerColorItemViewModel : BaseViewModel
    {
        private readonly string _playerName;
        private readonly TeamColorsViewModel _teamColors = null!;
        private readonly OutlineColorsViewModel _outlineColors = null!;

        public PlayerColorItemViewModel(string playerName, TeamColors teamColors, OutlineColors outlineColors)
        {
            _playerName = playerName;


            _teamColors = new TeamColorsViewModel() 
            { 
                FloatRGBA = new FloatRGBAViewModel() 
                { 
                    R = teamColors.FloatRGBA.R,
                    G = teamColors.FloatRGBA.G,
                    B = teamColors.FloatRGBA.B,
                    A = teamColors.FloatRGBA.A,
                } 
            };

            _outlineColors = new OutlineColorsViewModel()
            {
                FloatRGBA = new FloatRGBAViewModel()
                {
                    R = outlineColors.FloatRGBA.R,
                    G = outlineColors.FloatRGBA.G,
                    B = outlineColors.FloatRGBA.B,
                    A = outlineColors.FloatRGBA.A,
                }
            };

            _teamColors.FloatRGBA.PropertyChanged += (_, __) => { OnPropertyChanged(nameof(TeamColors)); };
            _outlineColors.FloatRGBA.PropertyChanged += (_, __) => { OnPropertyChanged(nameof(OutlineColors)); };
        }

        public string PlayerName => _playerName;
        public TeamColorsViewModel TeamColors => _teamColors;
        public OutlineColorsViewModel OutlineColors => _outlineColors;

        //public required string PlayerName { get; set; }
        //public required TeamColors TeamColors { get; set; }
        //public required OutlineColors OutlineColors { get; set; }
    }
}
