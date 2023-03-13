namespace Questao24.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somaNumeros = 0;

            for (double i = 1; i <= 500; i += 2)
            {
                if (i % 3 == 0)
                {
                    somaNumeros += i;
                }
            }

            Console.WriteLine("A soma dos números ímpares múltiplos de três entre 1 e 500 é: " + somaNumeros);
        }
    }
}