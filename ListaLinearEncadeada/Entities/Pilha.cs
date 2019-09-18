using ListaLinear.Entities.Exceptions;

namespace ListaLinear.Entities
{
    public static class Pilha
    {
        public static int Topo = -1;
        private static int Tamanho { get; set; }

        public static int Top(ref int[] pilha)
        {
            if (EstaVazio())
            {
                throw new RegraException("A lista está vázia");
            }
            else
            {
                return pilha[Topo];
            }
        }

        public static void Push(ref int[] pilha, int elemento)
        {
            if (EstaCheio())
            {
                throw new SemEspacoException("Pilha está cheia!");
            }
            else
            {
                Topo++;
                pilha[Topo] = elemento;
            }
        }

        public static void Pop(ref int[] pilha)
        {
            if (EstaVazio())
            {
                throw new RegraException("Está Vazio.");
            }
            else
            {
                pilha[Topo] = -1;
                Topo--;
            }
        }

        public static bool EstaVazio()
        {
            return Topo < 0;
        }

        public static bool EstaCheio()
        {
            return Topo == (Tamanho - 1);
        }
    }
}
