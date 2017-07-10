using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hast.Remote.Bridge.Models.Api;

namespace Hast.Remote.Bridge.Models
{
    public class TransformationJob : TransformationRequest
    {
        public int UserId { get; set; }
    }
}
