using ListaLinear.Entities;
using System;

namespace ListaLinear
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

            while (sair == false)
            {

                Console.WriteLine("1 - Inserir Elementos na lista");
                Console.WriteLine("2 - Encontrar Elemento pelo indice");
                Console.WriteLine("3 - Encontrar indice pelo Elemento");
                Console.WriteLine("4 - Remover elemento informado");
                Console.WriteLine("5 - Exibir Lista");
                Console.WriteLine("6 - Ordenar");
                Console.WriteLine("7 - Busca Binaria");
                Console.WriteLine("8 - Sair");
                Console.Write("Escolha o serviço: ");
                Console.WriteLine();
                Console.WriteLine();
                int opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        array.AdicionarElementoArray();
                        break;
                    case 2:
                        Console.Write("Digite o indice: ");
                        Console.WriteLine(array.ProcurarElementoPeloIndice(int.Parse(Console.ReadLine())));
                        break;
                    case 3:
                        Console.Write("Digite o Elemento: ");
                        Console.WriteLine(array.ProcurarIndicePeloElemento(int.Parse(Console.ReadLine())));
                        break;
                    case 4:
                        Console.Write("Digite o Elemento: ");
                        array.RemoverElementoInformado(int.Parse(Console.ReadLine()));
                        Console.WriteLine(array);
                        break;
                    case 5:
                        Console.WriteLine(array);
                        break;
                    case 6:
                        array.Orderar();
                        Console.WriteLine(array);
                        break;
                    case 7:
                        Console.Write("Digite o Elemento: ");
                        var posicao = array.BuscaBinaria(int.Parse(Console.ReadLine()));
                        Console.WriteLine(posicao);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcao invalida, tente novamente!");
                        break;

                }
                sair = Opcao.Continue();
                Console.Clear();
            }
        }
    }
}
