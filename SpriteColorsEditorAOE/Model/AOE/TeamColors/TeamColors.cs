using System.Text.Json.Serialization;

namespace SpriteColorsEditorAOE
{
    public class TeamColors
    {
        [JsonPropertyName("FloatRGBA")]
        public required FloatRGBA FloatRGBA { get; set; }
    }
}
