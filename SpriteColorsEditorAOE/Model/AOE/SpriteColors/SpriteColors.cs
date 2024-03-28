using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SpriteColorsEditorAOE
{
    public class SpriteColors
    {
        [JsonPropertyName("TeamColors")]
        public required Dictionary<string, TeamColors> TeamColors { get; set; }

        [JsonPropertyName("OutlineColors")]
        public required Dictionary<string, OutlineColors> OutlineColors { get; set; }
    }
}
