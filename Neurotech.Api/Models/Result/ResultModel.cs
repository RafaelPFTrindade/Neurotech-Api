using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public class ResultModel
    {
        public string OperationCode { get; set; }
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Result { get; set; }
        public ResultOutputModel[] Outputs { get; set; }
        public RuleResultModel[] RuleResults { get; set; }
    }
}
