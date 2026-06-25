
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleDeepSeek.Utilities
{
    [JsonSourceGenerationOptions(WriteIndented = true, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
    [JsonSerializable(typeof(ToolSchema))]
    [JsonSerializable(typeof(JsonSchema))]
    [JsonSerializable(typeof(FunctionDefinition))]
    [JsonSerializable(typeof(Tool))]
    [JsonSerializable(typeof(JsonElement))]
    [JsonSerializable(typeof(Dictionary<string, string>))]
    [JsonSerializable(typeof(Dictionary<string, object>))]
    [JsonSerializable(typeof(IList<Dictionary<string, object>>))]
    [JsonSerializable(typeof(List<Dictionary<string, object>>))]
    [JsonSerializable(typeof(IList<Tool>))]
    [JsonSerializable(typeof(List<Tool>))]
    public sealed partial class ToolSerializerContext : JsonSerializerContext
    {
    }
}
