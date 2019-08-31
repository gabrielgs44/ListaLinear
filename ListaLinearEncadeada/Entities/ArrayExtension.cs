using ListaLinearEncadeada.Entities.Exceptions;
using System;

namespace ListaLinearEncadeada.Entities
{
    public partial class ArrayEntitie
    {
        public int[] AdicionarElementoArray()
        {
            for (int i = Inicio; i < Final; i++)
            {
                Console.Write($"Digite o {Inicio + 1}° elemento da array: ");
                Array[i] = int.Parse(Console.ReadLine());
            }

            return Array;
        }

        public int ProcurarElementoPeloIndice(int indice)
        {
            for (int i = Inicio; i < Final; i++)
            {
                if (i == indice)
                    return Array[i];
            }

            throw new NaoEncontradoException("O indice não foi encontrado.");
        }

        public int ProcurarIndicePeloElemento(int elemento)
        {
            for (int i = Inicio; i < Final; i++)
            {
                if (Array[i].Equals(elemento))
                    return i;
            }

            throw new NaoEncontradoException("O Elemento não foi encontrado.");
        }

        public void RemoverElementoPeloIndice(int indice)
        {
            if (indice > Inicio && indice < Final)
            {
                Array[indice] = Array[Final - 1];
                Final--;
            }
            else
            {
                throw new NaoEncontradoException("Indice informado não existe!");
            }
        }

        public void RemoverElementoInformado(int elemento)
        {
            Array[ProcurarIndicePeloElemento(elemento)] = Array[Final - 1];
            Final--;
        }
    }
}
