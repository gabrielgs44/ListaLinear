using System.Text;

namespace ListaLinear.Entities
{
    public partial class ArrayEntitie
    {
        public int[] Array { get; private set; }
        private readonly int Tamanho;
        private int Final;
        private bool EstaOrdenado = false;

        public ArrayEntitie(int lenght)
        {
            Final = -1;
            Array = new int[lenght];
            Tamanho = lenght;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Final + 1; i++)
            {
                sb.AppendLine(Array[i].ToString());
            }

            return sb.ToString();
        }
    }
}
