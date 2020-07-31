using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Application.ValueObjects
{
    public class SubmitVO
    {
        public string Id { get; set; }

        public string Policy { get; set; }

        public string Version { get; set; }

        public string ResultingVariable { get; set; }

        public InputValueVO[] Inputs { get; set; }
    }
}
