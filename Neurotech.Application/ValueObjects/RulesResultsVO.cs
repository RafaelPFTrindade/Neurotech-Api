using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Application.ValueObjects
{
    public class RulesResultsVO
    {
        public string Result { get; set; }
        public OutputVO[] Outputs { get; set; }
        public RuleResultVO[] RuleResults { get; set; }
    }
}
