﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hast.Remote.Bridge.Models
{
    public class TransformationJobResult : TransformationResult
    {
        public string Token { get; set; }
        public int UserId { get; set; }
    }
}