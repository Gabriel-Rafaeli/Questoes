namespace Questao6.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.Write("Informe a temperatura em graus Celsius: ");
            celsius = Double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit + "°F.");
        }
    }
}