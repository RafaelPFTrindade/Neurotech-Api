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
        }

        public AuthenticationVO Authentication { get; set; }

        public SubmitVO Submit { get; set; }

        public PropertiesVO[] Properties { get; set; }

    }
}
