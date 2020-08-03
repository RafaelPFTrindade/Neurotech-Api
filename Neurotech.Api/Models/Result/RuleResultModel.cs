using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    /// <summary>
    /// Objetos que descrevem todas as regras que foram ativas durante a execução da política
    /// </summary>
    public partial class RuleResultModel
    {
        /// <summary>
        /// Nome da regra
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Status da regra
        /// </summary>
        public string FlagStatus { get; set; }
        /// <summary>
        /// Descrição da regra
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Descrição completa da regra
        /// </summary>
        public string DescricaoAnalitica { get; set; }

        /// <summary>
        /// Descrição resumida da regra
        /// </summary>
        public string DescricaoSintetica { get; set; }
        /// <summary>
        /// Lista com as variáveis de entrada da Regra
        /// </summary>
        public ResultInputModel[] LsEntradas { get; set; }
        /// <summary>
        /// Nome da regra pai
        /// </summary>
        public string RegraPai { get; set; }
        /// <summary>
        /// Data/Hora início da execução da regra
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Data/Hora fim da execução da regra
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}
