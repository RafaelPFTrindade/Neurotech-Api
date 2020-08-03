using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public class InputModel
    {
        /// <summary>
        ///  Nome do parâmetro de entrada. Exemplo: USUARIO, RETORNO_FILTRO_VARIAVEIS, RETORNO_FILTRO_REGEXES
        /// </summary>
        [Required]
        public string NmParametro { get; set; }

        /// <summary>
        /// Valor do parâmetro.
        /// </summary>
        public string VlParametro { get; set; }
    }
}
