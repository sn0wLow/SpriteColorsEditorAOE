using System.Text.Json.Serialization;

namespace SpriteColorsEditorAOE
{
    public class OutlineColors
    {
        [JsonPropertyName("FloatRGBA")]
        public required FloatRGBA FloatRGBA { get; set; }
    }
}
