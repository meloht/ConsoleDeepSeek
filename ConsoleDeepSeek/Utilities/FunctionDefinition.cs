using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsoleDeepSeek.Utilities
{
    /// <summary>
    /// A class for defining a function in an OpenAI-compatible way
    /// </summary>
    public class FunctionDefinition
    {
        [JsonPropertyName("name")]
        public required string Name { get; set; }
        [JsonPropertyName("description")]
        public required string Description { get; set; }
        [JsonPropertyName("parameters")]
        public required Dictionary<string, object> Parameters { get; set; }
    }
}
