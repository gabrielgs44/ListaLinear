using ListaLinear.Entities.Exceptions;
using System;

namespace ListaLinear.Entities
{
    public partial class ArrayEntitie
    {
        public void AdicionarElementoArray()
        {
            if (EstaVazio())
            {
                for (int i = 0; i < Tamanho; i++)
                {
                    Console.Write($"Digite o {i + 1}° elemento da array: ");
                    Array[i] = int.Parse(Console.ReadLine());
                    Final++;
                    EstaOrdenado = false;
                }
            }
            else if (EstaCheio())
            {
                throw new SemEspacoException("Sem espaço para adicionar elementos!");
            }
            else
            {
                for (int i = Final; i < Tamanho; i++)
                {
                    Console.Write($"Digite o {i + 1}° elemento da array: ");
                    Array[i] = int.Parse(Console.ReadLine());
                    Final++;
                    EstaOrdenado = false;
                }
            }
        }

        public int ProcurarElementoPeloIndice(int indice)
        {
            for (int i = 0; i < Final + 1; i++)
            {
                if (i == indice)
                    return Array[i];
            }

            throw new NaoEncontradoException("O indice não foi encontrado.");
        }

        public int ProcurarIndicePeloElemento(int elemento)
        {
            for (int i = 0; i < Final + 1; i++)
            {
                if (Array[i].Equals(elemento))
                    return i;
            }

            throw new NaoEncontradoException("O Elemento não foi encontrado.");
        }

        public void RemoverElementoInformado(int elemento)
        {
            Array[ProcurarIndicePeloElemento(elemento)] = Array[Final];
            Final--;
            EstaOrdenado = false;
        }

        public void Orderar()
        {
            int aux = 0;

            for (int i = 0; i < Final + 1; i++)
            {
                for (int j = 0; j < Final + 1; j++)
                {
                    if (j < Final)
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

            EstaOrdenado = true;
        }

        public int BuscaBinaria(int elemento)
        {
            if (!EstaOrdenado)
                throw new RegraException("É necessário está ornado para realizar a busca binária!");

            int meio = Array[0 + (Final) / 2];

            if (elemento == meio)
            {
                return 0 + (Final) / 2;
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
                for (int i = meio; i < Final + 1; i++)
                {
                    if (Array[i] == elemento)
                        return i;
                }
            }

            throw new NaoEncontradoException("Elemento informado não foi encontrado.");
        }

        public void Push(int elemento)
        {
            if (EstaCheio())
                throw new SemEspacoException("Não é possível adicionar mais elementos.");
            else
                Array[Final] = elemento;

            EstaOrdenado = false;

        }

        public int Pop()
        {
            if (EstaVazio())
                throw new NaoEncontradoException("Não possui elemento para ser removido");
            else
            {
                Final--;
                return Array[Final + 1];
            }
        }

        public int Top()
        {
            if (EstaVazio())
            {
                throw new NaoEncontradoException("A Pilha está vázia");
            }
            else
            {
                return Array[Final];
            }
        }

        private bool EstaVazio()
        {
            return Final < 0;
        }

        private bool EstaCheio()
        {
            return Final == (Tamanho - 1);
        }
    }
}
