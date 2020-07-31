using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Application.ValueObjects
{
    public class ResultVO
    {
        public string OperationCode { get; set; }
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RulesResultsVO Result { get; set; }
    }
}
