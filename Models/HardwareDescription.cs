using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hast.Remote.Bridge.Models
{
    public class HardwareDescription
    {
        public string Language { get; set; }
        public Dictionary<string, int> HardwareEntryPointNamesToMemberIdMappings { get; set; }
        public string Source { get; set; }
    }
}
