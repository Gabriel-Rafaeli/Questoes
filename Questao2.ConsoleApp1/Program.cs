using System.Globalization;

namespace Questao2.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine(fahrenheit + " graus fahrenheit equivalem a " + celsius.ToString("F2", CultureInfo.InvariantCulture) + " graus celsius.");
        }
    }
}