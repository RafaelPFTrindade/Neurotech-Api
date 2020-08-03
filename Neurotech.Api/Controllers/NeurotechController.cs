using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Neurotech.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Neurotech.Application.ValueObjects;
using Neurotech.Application.Commands;
using AutoMapper;

namespace Neurotech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeurotechController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public NeurotechController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// Recurso para consultar o motor Neurotech
        /// </summary>
        /// <remarks></remarks>
        /// <param name="model">Modelo com os parâmetros de entrada</param>
        /// <returns>Resposta obtida pelo motor após análise</returns>
        [HttpPost]
        [Route("sync-register")]
        public async Task<IActionResult> Post([FromBody]RegisterModel model)
        {
            var command = new RegisterCommand(_mapper.Map<SubmitVO>(model));
            var result = _mapper.Map<ResultModel>(await _mediator.Send(command));
            return Ok(result);
        }
    }
}
