using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hast.Remote.Bridge.Models
{
    public class TransformationJob : TransformationRequest
    {
        public string Token { get; set; }
        public int UserId { get; set; }
    }
}
