using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsoleDeepSeek.Utilities
{
    /// <summary>
    /// A class for defining a JSON schema for guidance
    /// </summary>
    public class JsonSchema
    {
        [JsonPropertyName("x-guidance")]
        public required Dictionary<string, object> XGuidance { get; set; }
        [JsonPropertyName("type")]
        public required string Type { get; set; }
        [JsonPropertyName("items")]
        public required Dictionary<string, IList<ToolSchema>> Items { get; set; }
        [JsonPropertyName("minItems")]
        public required int MinItems { get; set; }
    }
}
