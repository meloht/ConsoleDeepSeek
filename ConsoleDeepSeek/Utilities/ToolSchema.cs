using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsoleDeepSeek.Utilities
{
    /// <summary>
    /// A class for defining a tool in a JSON schema compatible way
    /// </summary>
    public class ToolSchema
    {
        [JsonPropertyName("description")]
        public required string Description { get; set; }
        [JsonPropertyName("type")]
        public required string Type { get; set; }
        [JsonPropertyName("properties")]
        public required Dictionary<string, object> Properties { get; set; }
        [JsonPropertyName("required")]
        public required IList<string> Required { get; set; }
        [JsonPropertyName("additionalProperties")]
        public required bool AdditionalProperties { get; set; }
    }
}
