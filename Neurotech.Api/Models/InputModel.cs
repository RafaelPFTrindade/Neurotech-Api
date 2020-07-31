using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Neurotech.Api.Models
{
    public class InputModel
    {
        [Required]
        public string NmParametro { get; set; }

        public string VlParametro { get; set; }
    }
}
