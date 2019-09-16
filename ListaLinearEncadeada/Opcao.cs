using System;

namespace ListaLinear
{
    public static class Opcao
    {
        public static bool Continue()
        {
            Console.WriteLine("Deseja continuar (S/N)");
            char opcao = char.Parse(Console.ReadLine().ToUpper());

            return opcao == 'N';
        }
    }
}
