namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDiamante, quantidadeLinhas, quantidadeEspacos;

            int quantidadeX = 1;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Bem-vindo a mina de diamante X :D");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Para começar digite o tamanho central do diamante!");
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

            // Parte de cima do diamante
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

            // Parte do meio do diamante
            for (int i = 0; i < tamanhoDiamante; i++)
            {
                Console.Write("X");
            }
            Console.WriteLine();

            // Parte de baixo do diamante
            for (int i = 0; i < quantidadeLinhas; i++)
            {
                quantidadeEspacos++;
                quantidadeX -= 2;
                for (int j = 0; j < quantidadeEspacos; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < quantidadeX; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
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
