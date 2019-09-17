using ListaLinear.Entities.Exceptions;
using System;

namespace ListaLinear.Entities
{
    public partial class ArrayEntitie
    {
        public void AdicionarElementoArray()
        {
            if (!(Tamanho == Final))
            {
                for (int i = Final; i < Tamanho; i++)
                {
                    Console.Write($"Digite o {i + 1}° elemento da array: ");
                    Array[i] = int.Parse(Console.ReadLine());
                    Final++;
                }
            }
            else
            {
                throw new SemEspacoException("Sem espaço para adicionar elementos!");
            }
        }

        public int ProcurarElementoPeloIndice(int indice)
        {
            for (int i = 0; i < Final; i++)
            {
                if (i == indice)
                    return Array[i];
            }

            throw new NaoEncontradoException("O indice não foi encontrado.");
        }

        public int ProcurarIndicePeloElemento(int elemento)
        {
            for (int i = 0; i < Final; i++)
            {
                if (Array[i].Equals(elemento))
                    return i;
            }

            throw new NaoEncontradoException("O Elemento não foi encontrado.");
        }

        public void RemoverElementoInformado(int elemento)
        {
            Array[ProcurarIndicePeloElemento(elemento)] = Array[Final - 1];
            Final--;
        }

        public void Orderar()
        {
            int aux = 0;

            for (int i = 0; i < Final; i++)
            {
                for (int j = 0; j < Final; j++)
                {
                    if (j < (Final - 1))
                    {
                        if (Array[j] > Array[j + 1])
                        {

                            aux = Array[j];
                            Array[j] = Array[j + 1];
                            Array[j + 1] = aux;

                        }
                    }
                }
            }
        }

        public int BuscaBinaria(int elemento)
        {
            Orderar();

            int meio = Array[0 + (Final - 1) / 2];

            if (elemento == meio)
            {
                return 0 + (Final - 1) / 2;
            }
            else if (elemento < meio)
            {
                for (int i = 0; i < meio; i++)
                {
                    if (Array[i] == elemento)
                        return i;
                }
            }
            else
            {
                for (int i = meio; i < Final; i++)
                {
                    if (Array[i] == elemento)
                        return i;
                }
            }

            throw new NaoEncontradoException("Elemento informado não foi encontrado.");
        }
    }
}
