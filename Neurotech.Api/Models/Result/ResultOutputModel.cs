using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public partial class ResultOutputModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public object Type { get; set; }
    }
}
