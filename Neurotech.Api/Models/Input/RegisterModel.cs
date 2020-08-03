using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public class RegisterModel
    {
        /// <summary>
        /// Identificação da Proposta
        /// </summary>
        [Key]
        public string IdProposta { get; set; }

        /// <summary>
        /// Nome da Política cadastrada na aplicação que será chamada no Webservice
        /// </summary>
        [Required]
        public string NmPolitica { get; set; }

        /// <summary>
        /// Versão da política que deve ser usada na submissão da proposta. Deixando em branco, será usada a versão mais recente. 
        /// </summary>
        public string TagVersaoPolitica { get; set; }

        /// <summary>
        /// Guarda a informação de que variável dentro do Workflow guarda o resultado final do fluxo. Normalmente deve ser igual a FLX_PRINCIPAL.
        /// </summary>
        public string NmFluxoResultado { get; set; }

        /// <summary>
        /// Dados para identificação do serviço chamador. Deixando em branco, utilizaremos o usuário do appsettings.
        /// </summary>
        public CredenciaisModel Credenciais { get; set; }

        /// <summary>
        /// É um array, uma lista, de objetos do tipo ParametroFluxo, cada objeto ParametroFluxo tem dois atributos: NmParametro e VlParametro.
        /// </summary>
        public InputModel[] LsParametros { get; set; }
    }
}
