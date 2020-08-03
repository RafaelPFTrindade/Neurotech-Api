using Neurotech.Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public partial class ResultOutputModel
    {
        public ResultOutputModel(OutputVO model)
        {
            Key = model.Key;
            Value = model.Value;
            Type = model.Type;
        }
    }
}
