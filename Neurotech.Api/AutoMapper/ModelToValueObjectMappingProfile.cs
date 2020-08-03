using AutoMapper;
using Neurotech.Application.ValueObjects;
using Neurotech.Api.Models;
using System.Linq;

namespace Neurotech.Api.AutoMapper
{
    public class ModelToValueObjectMappingProfile : Profile
    {
        public ModelToValueObjectMappingProfile()
        {
            CreateMap<RegisterModel, SubmitVO>()
                .ForMember(d => d.Id, opts => opts.MapFrom(s => s.IdProposta))
                .ForMember(d => d.Policy, opts => opts.MapFrom(s => s.NmPolitica))
                .ForMember(d => d.ResultingVariable, opts => opts.MapFrom(s => s.NmFluxoResultado))
                .ForMember(d => d.Version, opts => opts.MapFrom(s => s.TagVersaoPolitica))
                .ForMember(d => d.Inputs, opts => opts.MapFrom(s => s.LsParametros.Select(x => new InputValueVO(x.NmParametro, x.VlParametro))));

            CreateMap<CredenciaisModel, AuthenticationVO>()
                .ForMember(d => d.Login, opts => opts.MapFrom(s => s.nmCodigoAssociado))
                .ForMember(d => d.Password, opts => opts.MapFrom(s => s.nmSenha));

        }
    }
}
