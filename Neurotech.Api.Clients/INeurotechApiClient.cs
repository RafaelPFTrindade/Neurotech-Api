using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Neurotech.Application.ValueObjects;
using Neurotech.Api.Models;

namespace Neurotech.Api.Clients
{
    public interface INeurotechApiClient
    {

        /// <summary>
        /// Recurso para registrar 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Post("/api/neurotech/")]
        Task<ResultVO> Post(RegisterModel model);
    }
}
