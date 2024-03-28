using System.Text.Json.Serialization;

namespace SpriteColorsEditorAOE
{
    public class FloatRGBA : IFloatRGBA
    {
        [JsonPropertyName("r")]
        public float R { get; set; }

        [JsonPropertyName("g")]
        public float G { get; set; }

        [JsonPropertyName("b")]
        public float B { get; set; }

        [JsonPropertyName("a")]
        public float A { get; set; }

        //[JsonPropertyName("argb")]
        //public required string ARGB { get; set; }

        [JsonIgnore]
        public string ARGB
        {
            get
            {
                int a = (int)(A * 255);
                int r = (int)(R * 255);
                int g = (int)(G * 255);
                int b = (int)(B * 255);

                return $"{a:X2}{r:X2}{g:X2}{b:X2}";
            }
            set
            {
                int argbInt = int.Parse(value, System.Globalization.NumberStyles.HexNumber);

                A = ((argbInt >> 24) & 0xFF) / 255.0f;
                R = ((argbInt >> 16) & 0xFF) / 255.0f;
                G = ((argbInt >> 8) & 0xFF) / 255.0f;
                B = (argbInt & 0xFF) / 255.0f;
            }
        }

    }
}
