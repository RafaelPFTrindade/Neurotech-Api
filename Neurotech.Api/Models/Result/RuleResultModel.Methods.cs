using Neurotech.Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public partial class RuleResultModel
    {
        public RuleResultModel(RuleResultVO model)
        {
            Nome = model.Name;
            LsEntradas = model.Inputs?.Select(i => new ResultInputModel(i)).ToArray();
            EndTime = model.EndTime;
            RegraPai = model.ParentRuleName;
            DescricaoAnalitica = model.ResultCompleteDescription;
            DescricaoSintetica = model.ResultSimpleDescription;
            Descricao = model.RuleDescription;
            StartTime = model.StartTime;
            FlagStatus = model.Status;
        }
    }
}
