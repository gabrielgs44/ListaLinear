using System.Text;

namespace ListaLinear.Entities
{
    public partial class ArrayEntitie
    {
        public int[] Array { get; private set; }
        private readonly int Tamanho;
        private int Final;

        public ArrayEntitie(int lenght)
        {
            Final = 0;
            Array = new int[lenght];
            Tamanho = lenght;
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
