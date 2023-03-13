namespace Questao22.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            int c = 0;

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("Os valores são iguais. A soma de C é: " + c);
            }
            else
            {
                c = a * b;
                Console.WriteLine("Os valores são diferentes. A multiplicação de C é: " + c);
            }
        }
    }
}