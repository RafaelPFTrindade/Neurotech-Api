using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public class ResultOutputModel
    {
        public ResultOutputModel(string key, string value, object type)
        {
            Key = key;
            Value = value;
            Type = type;
        }

        public string Key { get; set; }
        public string Value { get; set; }
        public object Type { get; set; }
    }
}
