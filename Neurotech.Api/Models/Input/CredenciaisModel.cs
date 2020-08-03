using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public class CredenciaisModel
    {
        /// <summary>
        ///  Este código representa o cadastro do cliente na base da Neurotech.
        /// </summary>
        public string nmCodigoAssociado { get; set; }

        /// <summary>
        /// É o código da filial que está submetendo a proposta. Informar 0 se não possuir filiais.
        /// </summary>
        public string nmCodigoFilial { get; set; }

        /// <summary>
        /// Senha de utilização do Webservice, por filial
        /// </summary>
        public string nmSenha { get; set; }
    }
}
