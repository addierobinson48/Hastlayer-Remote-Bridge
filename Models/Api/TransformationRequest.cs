using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hast.Remote.Bridge.Models.Api
{
    public class TransformationRequest
    {
        public HardwareGenerationConfiguration Configuration { get; set; }
        public IEnumerable<AssemblyContainer> Assemblies { get; set; }
    }
}
