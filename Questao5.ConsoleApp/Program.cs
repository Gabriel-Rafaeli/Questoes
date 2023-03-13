using System.Globalization;

namespace Questao5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor do raio (r): ");

            double R = double.Parse(Console.ReadLine());
            double RaioCubo = Math.Pow(R, 3);
            double volume = (4.0 / 3) * Math.PI * RaioCubo;

            Console.WriteLine("Volume = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}