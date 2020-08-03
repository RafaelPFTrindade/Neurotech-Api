using MediatR;
using Neurotech.Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Application.Commands
{
    public class RegisterCommand : IRequest<ResultVO>
    {

        public RegisterCommand(SubmitVO submit)
        {
            Submit = submit;
            Properties = new PropertiesVO[1];
            Properties[0] = new PropertiesVO("FILIAL_ID", "0");
        }

        public RegisterCommand(SubmitVO submit, AuthenticationVO authenticationVO, string nmCodigoFilial)
        {
            Submit = submit;
            Authentication = authenticationVO;
            Properties = new PropertiesVO[1];
            Properties[0] = string.IsNullOrEmpty(nmCodigoFilial) ? new PropertiesVO("FILIAL_ID", "0") : new PropertiesVO("FILIAL_ID", nmCodigoFilial);
        }

        public AuthenticationVO Authentication { get; set; }

        public SubmitVO Submit { get; set; }

        public PropertiesVO[] Properties { get; set; }

    }
}
