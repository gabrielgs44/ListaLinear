using System.Text;

namespace ListaLinearEncadeada.Entities
{
    public partial class ArrayEntitie
    {
        public int[] Array { get; private set; }
        private readonly int Inicio = 0;
        private int Final;

        public ArrayEntitie(int lenght)
        {
            Final = lenght;
            Array = new int[lenght];
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
