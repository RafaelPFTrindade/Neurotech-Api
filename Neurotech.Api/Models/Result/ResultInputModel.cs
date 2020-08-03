using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    /// <summary>
    /// Classe com as variáveis de entrada de uma regra
    /// </summary>
    public partial class ResultInputModel
    {
        /// <summary>
        /// Nome da variável de entrada da regra
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Valor da variável de entrada da regra
        /// </summary>
        public string Valor { get; set; }

        /// <summary>
        /// Descrição da variável de entrada
        /// </summary>
        public object Descricao { get; set; }
        /// <summary>
        /// Ordem da variável de entrada
        /// </summary>
        public object Ordem { get; set; }
        /// <summary>
        /// Visibilidade da variável de entrada
        /// </summary>
        public object Visibilidade { get; set; }
    }
}
