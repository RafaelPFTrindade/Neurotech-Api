using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    /// <summary>
    /// Modelo do retorno da chamada do motor
    /// </summary>
    public class ResultModel
    {
        /// <summary>
        /// é o identificador único da proposta processada
        /// </summary>
        public string CdOperacao { get; set; }

        /// <summary>
        /// Código da Mensagem Final
        /// </summary>
        public string CdMensagem { get; set; }

        /// <summary>
        /// Descrição da mensagem final
        /// </summary>
        public string DsMensagem { get; set; }

        /// <summary>
        /// Hora de início do processamento
        /// </summary>
        public DateTime HoraInicio { get; set; }

        /// <summary>
        /// Hora do fim do processamento
        /// </summary>
        public DateTime HoraFim { get; set; }

        /// <summary>
        /// Valor que a variável NmFluxoResultado, passada como parâmetro adquire ao final do processamento de dados
        /// </summary>
        public string Resultado { get; set; }
        
        /// <summary>
        /// Uma lista contendo as variáveis desta política 
        /// </summary>
        public ResultOutputModel[] lsRetorno { get; set; }

        /// <summary>
        /// Uma lista de objetos do tipo RetornoRegra que descreve todas as regras que foram ativas durante a execução da política.
        /// </summary>
        public RuleResultModel[] LsRegra { get; set; }
    }
}
