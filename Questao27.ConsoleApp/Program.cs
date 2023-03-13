namespace Questao27.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double numero, proximo;
                double anterior = 0;
                double atual = 1;

                Console.Write("Digite um número: ");
                numero = double.Parse(Console.ReadLine());

                Console.Write($"Sequência de Fibonacci até o número {numero}: ");

                while (atual <= numero)
                {
                    Console.Write("  " + atual);

                    proximo = anterior + atual;
                    anterior = atual;
                    atual = proximo;
                }
            }
        }
    }
}