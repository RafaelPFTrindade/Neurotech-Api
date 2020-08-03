using AutoMapper;
using Neurotech.Api.Models;
using Neurotech.Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Neurotech.Api.AutoMapper
{
    public class ValueObjectToModelMappingProfile : Profile
    {
        public ValueObjectToModelMappingProfile()
        {
            CreateMap<ResultVO, ResultModel>()
                .ForMember(d => d.EndTime, opts => opts.MapFrom(s => s.EndTime))
                .ForMember(d => d.Message, opts => opts.MapFrom(s => s.Message))
                .ForMember(d => d.OperationCode, opts => opts.MapFrom(s => s.OperationCode))
                .ForMember(d => d.Result, opts => opts.MapFrom(s => s.Result.Result))
                .ForPath(d => d.Outputs, opts => opts.MapFrom(s => s.Result.Outputs.Select(x => new ResultOutputModel(x.Key, x.Value, x.Type))))
                .ForPath(d => d.RuleResults, opts => opts.MapFrom(s => s.Result.RuleResults.Select(x => new RuleResultModel(x))));
        }
    }
}
