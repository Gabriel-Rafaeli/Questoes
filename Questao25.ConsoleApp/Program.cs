namespace Questao25.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número de 1 a 10: ");
            double valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada de:" + valor);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {valor} = {i * valor}");
            }
        }
    }
}