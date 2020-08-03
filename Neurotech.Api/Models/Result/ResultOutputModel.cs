using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    /// <summary>
    /// Modelo de dados chave-valor 
    /// </summary>
    public partial class ResultOutputModel
    {
        /// <summary>
        /// Chave da variável
        /// </summary>
        public string Chave { get; set; }
        /// <summary>
        /// Valor da variável
        /// </summary>
        public string Valor { get; set; }
        /// <summary>
        /// Tipo da variável
        /// </summary>
        public object Tipo { get; set; }
    }
}
