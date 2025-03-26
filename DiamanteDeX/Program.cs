namespace DiamanteDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDiamante = 0;

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
