namespace Questao3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o raio da base do cilindro em metros: ");
            double raio = Double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do cilindro em metros: ");
            double altura = Double.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume do cilindro é: " + volume + " metros cúbicos.");
        }
    }
}