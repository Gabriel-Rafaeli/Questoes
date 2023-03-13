namespace Questao11.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double divisores = 0;

            Console.WriteLine("Digite o número: ");
            double numero = double.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    divisores++;
            }
            if (divisores == 2)
                Console.WriteLine(" É um número primo");
            else
                Console.WriteLine(" Não é um número primo");
        }
    }
}
