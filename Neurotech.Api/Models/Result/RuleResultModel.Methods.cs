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
            Name = model.Name;
            Inputs = model.Inputs?.Select(i => new ResultInputModel(i)).ToArray();
            EndTime = model.EndTime;
            ParentRuleName = model.ParentRuleName;
            ResultCompleteDescription = model.ResultCompleteDescription;
            ResultSimpleDescription = model.ResultSimpleDescription;
            RuleDescription = model.RuleDescription;
            StartTime = model.StartTime;
            Status = model.Status;
        }
    }
}
