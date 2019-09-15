using System;

namespace ListaLinear.Entities.Exceptions
{
    public class NaoEncontradoException: Exception
    {
        public NaoEncontradoException(string message) : base(message)
        {

        }
    }
}
