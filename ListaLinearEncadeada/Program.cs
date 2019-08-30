using ListaLinearEncadeada.Entities;
using System;

namespace ListaLinearEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Tamanho do vetor: ");
            ArrayEntitie array = new ArrayEntitie(int.Parse(Console.ReadLine()));

            array.AdicionarElementoArray();

            Console.WriteLine(array);
        }
    }
}
