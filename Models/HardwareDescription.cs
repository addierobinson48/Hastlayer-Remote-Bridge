using System.Collections.Generic;

namespace Hast.Remote.Bridge.Models
{
    public class HardwareDescription
    {
        public string Language { get; set; }
        public Dictionary<string, int> HardwareEntryPointNamesToMemberIdMappings { get; set; }
        public string Source { get; set; }
    }
}
