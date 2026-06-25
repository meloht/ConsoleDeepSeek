using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsoleDeepSeek.Utilities
{
    [JsonSourceGenerationOptions(WriteIndented = true, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
    [JsonSerializable(typeof(GeneratorParamsArgs))]
    [JsonSerializable(typeof(GuidanceArgs))]
    public sealed partial class ArgsSerializerContext : JsonSerializerContext
    {
    }
}
