using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public class RegisterModel
    {
        [Key]
        public string IdProposta { get; set; }

        [Required]
        public string NmPolitica { get; set; }

        public string TagVersaoPolitica { get; set; }

        public string NmFluxoResultado { get; set; }

        public InputModel[] LsParametros { get; set; }
    }
}
