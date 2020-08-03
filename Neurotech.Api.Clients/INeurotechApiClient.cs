using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Neurotech.Api.Models;

namespace Neurotech.Api.Clients
{
    public interface INeurotechApiClient
    {
        /// <summary>
        /// Recurso para consultar o motor Neurotech
        /// </summary>
        /// <remarks></remarks>
        /// <param name="model">Modelo com os parâmetros de entrada</param>
        /// <returns>Resposta obtida pelo motor após análise</returns>
        [Post("/api/neurotech/sync-register")]
        Task<ResultModel> Post(RegisterModel model);
    }
}
