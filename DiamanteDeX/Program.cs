namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDiamante, quantidadeLinhas, quantidadeEspacos;

            int quantidadeX = 1;

            mostrarCabecalho();
            Console.Write("Tamanho: ");
            tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            while(!ValidarEntrada(tamanhoDiamante))
            {
                Console.WriteLine("O tamanho do diamante deve ser um número ímpar!");
                Console.Write("Tamanho: ");
                tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
            }

            quantidadeLinhas = (tamanhoDiamante - 1) / 2;
            quantidadeEspacos = quantidadeLinhas;

            desenharParteDeCima(quantidadeLinhas, quantidadeEspacos, quantidadeX);
            desenharParteDoMeio(tamanhoDiamante);
            quantidadeX = tamanhoDiamante;
            desenharParteDeBaixo(quantidadeLinhas, quantidadeEspacos, quantidadeX);

            Console.ReadLine();
        }

        static void mostrarCabecalho()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Bem-vindo a mina de diamante X :D");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Para começar digite o tamanho central do diamante!");
        }

        static void desenharParteDeCima(int quantidadeLinhas, int quantidadeEspacos, int quantidadeX)
        {
            for (int i = 0; i < quantidadeLinhas; i++)
            {
                for (int j = 0; j < quantidadeEspacos; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < quantidadeX; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
                quantidadeEspacos--;
                quantidadeX += 2;
            }
        }

        static void desenharParteDoMeio(int tamanhoDiamante)
        {
            for (int i = 0; i < tamanhoDiamante; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine();
        }

        static void desenharParteDeBaixo(int quantidadeLinhas, int quantidadeEspacos, int quantidadeX)
        {
            quantidadeX -= 2;
            quantidadeEspacos = 1;
            for (int i = 0; i < quantidadeLinhas; i++)
            {
                for (int j = 0; j < quantidadeEspacos; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < quantidadeX; j++)
                {
                    Console.Write("X");
                }

                quantidadeX -= 2;
                quantidadeEspacos++;
                Console.WriteLine();
            }
        }

        static bool ValidarEntrada(int tamanhoDiamante)
        {
            if (tamanhoDiamante % 2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
