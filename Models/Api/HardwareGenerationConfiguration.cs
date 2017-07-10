using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hast.Remote.Bridge.Models.Api
{
    public class HardwareGenerationConfiguration
    {
        public IDictionary<string, object> CustomConfiguration { get; set; }
        public IList<string> HardwareEntryPointMemberFullNames { get; set; }
        public IList<string> HardwareEntryPointMemberNamePrefixes { get; set; }
        public string DeviceName { get; set; }
    }
}
