using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsoleDeepSeek.Utilities
{
    /// <summary>
    /// A class for defining a tool in an OpenAI-compatible way
    /// </summary>
    public class Tool
    {
        [JsonPropertyName("type")]
        public required string Type { get; set; }
        [JsonPropertyName("function")]
        public required FunctionDefinition Function { get; set; }
    }
}
