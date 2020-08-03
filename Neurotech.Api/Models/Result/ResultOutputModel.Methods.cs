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
            Chave = model.Key;
            Valor = model.Value;
            Tipo = model.Type;
        }
    }
}
