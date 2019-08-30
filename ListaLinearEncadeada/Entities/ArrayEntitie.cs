using System;
using System.Collections.Generic;
using System.Text;

namespace ListaLinearEncadeada.Entities
{
    public class ArrayEntitie
    {
        public int[] Array { get; private set; }
        private readonly int Inicio = 0;
        private int Final;

        public ArrayEntitie(int lenght)
        {
            Final = lenght;
            Array = new int[lenght];
        }

        public int[] AdicionarElementoArray()
        {
            for(int i = 0; i < Final; i++)
            {
                Console.Write($"Digite o {Inicio+1}° elemento da array: ");
                Array[i] = int.Parse(Console.ReadLine());
            }

            return Array;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Final; i++)
            {
                sb.AppendLine(Array[i].ToString());
            }

            return sb.ToString();
        }
    }
}
