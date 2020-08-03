using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public partial class ResultInputModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public object Description { get; set; }
        public object Order { get; set; }
        public object Visible { get; set; }
    }
}
