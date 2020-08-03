using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public class ResultInputModel
    {
        public ResultInputModel(string name, string value, object description, object order, object visible)
        {
            Name = name;
            Value = value;
            Description = description;
            Order = order;
            Visible = visible;
        }

        public string Name { get; set; }
        public string Value { get; set; }
        public object Description { get; set; }
        public object Order { get; set; }
        public object Visible { get; set; }
    }
}
