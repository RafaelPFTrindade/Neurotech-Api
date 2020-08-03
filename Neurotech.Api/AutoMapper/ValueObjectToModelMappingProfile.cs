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
                .ForMember(d => d.HoraFim, opts => opts.MapFrom(s => s.EndTime))
                .ForMember(d => d.DsMensagem, opts => opts.MapFrom(s => s.Message))
                .ForMember(d => d.CdOperacao, opts => opts.MapFrom(s => s.OperationCode))
                .ForMember(d => d.CdMensagem, opts => opts.MapFrom(s => s.StatusCode))
                .ForMember(d => d.HoraInicio, opts => opts.MapFrom(s => s.StartTime))
                .ForMember(d => d.Resultado, opts => opts.MapFrom(s => s.Result.Result))
                .ForPath(d => d.lsRetorno, opts => opts.MapFrom(s => s.Result.Outputs.Select(x => new ResultOutputModel(x))))
                .ForPath(d => d.LsRegra, opts => opts.MapFrom(s => s.Result.RuleResults.Select(x => new RuleResultModel(x))));
        }
    }
}
