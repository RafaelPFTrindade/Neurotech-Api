using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Application.ValueObjects
{
    public class RuleResultVO
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string RuleDescription { get; set; }
        public string ResultCompleteDescription { get; set; }
        public string ResultSimpleDescription { get; set; }
        public InputVO[] Inputs { get; set; }
        public string ParentRuleName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
