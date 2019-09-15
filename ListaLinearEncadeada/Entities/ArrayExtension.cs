using ListaLinear.Entities.Exceptions;
using System;

namespace ListaLinear.Entities
{
    public partial class ArrayEntitie
    {
        public int[] AdicionarElementoArray()
        {
            if (!(Tamanho == Final))
            {
                for (int i = Final; i < Tamanho; i++)
                {
                    Console.Write($"Digite o {i + 1}° elemento da array: ");
                    Array[i] = int.Parse(Console.ReadLine());
                    Final++;
                }

                return Array;
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
    }
}
