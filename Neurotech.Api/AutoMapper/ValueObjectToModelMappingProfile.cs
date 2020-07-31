using AutoMapper;
using Neurotech.Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.AutoMapper
{
    public class ValueObjectToModelMappingProfile : Profile
    {
        public ValueObjectToModelMappingProfile()
        {
            CreateMap<ResultVO, InputVO>()
            ;

        }
    }
}
