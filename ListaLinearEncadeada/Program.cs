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

            bool sair = false;

            while(sair == false)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1 - Encontrar Elemento pelo indice");
                Console.WriteLine("2 - Encontrar indice pelo Elemento");
                Console.WriteLine("3 - Remover elemento pelo indice informado");
                Console.WriteLine("4 - Remover elemento informado");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha o serviço: ");
                Console.WriteLine();
                Console.WriteLine();

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o indice: ");
                        Console.WriteLine(array.ProcurarElementoPeloIndice(int.Parse(Console.ReadLine())));
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Digite o Elemento: ");
                        Console.WriteLine(array.ProcurarIndicePeloElemento(int.Parse(Console.ReadLine())));
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Digite o indice: ");
                        array.RemoverElementoPeloIndice(int.Parse(Console.ReadLine()));
                        Console.WriteLine(array);
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Digite o Elemento: ");
                        array.RemoverElementoInformado(int.Parse(Console.ReadLine()));
                        Console.WriteLine(array);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine(array);
                        sair = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcao invalida, tente novamente!");
                        break;

                }
            }
        }
    }
}
