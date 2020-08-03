using Neurotech.Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public partial class ResultInputModel
    {
        public ResultInputModel(InputVO model)
        {
            Nome = model.Name;
            Valor = model.Value;
            Descricao = model.Description;
            Ordem = model.Order;
            Visibilidade = model.Visible;
        }
    }
}
