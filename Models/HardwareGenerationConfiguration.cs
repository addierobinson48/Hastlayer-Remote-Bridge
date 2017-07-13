using System.Collections.Generic;

namespace Hast.Remote.Bridge.Models
{
    public class HardwareGenerationConfiguration
    {
        public IDictionary<string, object> CustomConfiguration { get; set; }
        public IList<string> HardwareEntryPointMemberFullNames { get; set; }
        public IList<string> HardwareEntryPointMemberNamePrefixes { get; set; }
        public string DeviceName { get; set; }
    }
}
