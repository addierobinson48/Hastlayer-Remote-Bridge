using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hast.Remote.Bridge.Models.Api
{
    public class TransformationResult
    {
        public HardwareDescription HardwareDescription { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
