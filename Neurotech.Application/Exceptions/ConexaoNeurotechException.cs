using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Application.Exceptions
{
    public class ConexaoNeurotechException : Exception
    {
        public ConexaoNeurotechException() : base($"Erro de comunicação com o Neurotech") { }
    }
}
