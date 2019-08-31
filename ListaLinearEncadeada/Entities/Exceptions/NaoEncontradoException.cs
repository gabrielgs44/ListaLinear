using System;

namespace ListaLinearEncadeada.Entities.Exceptions
{
    public class NaoEncontradoException: Exception
    {
        public NaoEncontradoException(string message) : base(message)
        {

        }
    }
}
