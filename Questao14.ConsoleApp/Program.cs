namespace Questao14.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int diasDeVida = idade * 365;

            Console.WriteLine(nome + ", já viveu " + diasDeVida + " dias!");
        }
    }
}