using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDeepSeek.Utilities
{
    /// <summary>
    /// A class for holding parsed values for guidance
    /// </summary>
    public class GuidanceArgs
    {
        public string response_format { get; set; } = "";
        public string tools_file { get; set; } = "";
        public bool text_output { get; set; } = false;
        public bool tool_output { get; set; } = false;
        public string tool_call_start { get; set; } = "";
        public string tool_call_end { get; set; } = "";
    }
}
