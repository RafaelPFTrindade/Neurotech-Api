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
            Name = model.Name;
            Value = model.Value;
            Description = model.Description;
            Order = model.Order;
            Visible = model.Visible;
        }
    }
}
