namespace SpriteColorsEditorAOE
{
    public class PlayerColorItemDesignModel
    {
        public PlayerColorItemDesignModel()
        {
            PlayerName = "Gaia";
            OutlineColors = new OutlineColors() { FloatRGBA = new FloatRGBA() { R = 10 / 255.0f, G = 150 / 255.0f, B = 150 / 255.0f, A = 1 } };
            TeamColors = new TeamColors() { FloatRGBA = new FloatRGBA() { R = 20 / 255.0f, G = 200 / 255.0f, B = 200 / 255.0f, A = 1 } };
        }

        public required string PlayerName { get; set; }
        public required TeamColors TeamColors { get; set; }
        public required OutlineColors OutlineColors { get; set; }
    }
}
