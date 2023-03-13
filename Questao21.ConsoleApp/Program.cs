namespace Questao21.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int resultado;

            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 == valor2)
            {
                resultado = valor1 + valor2;

                Console.WriteLine("A soma dos valores  foi de: " + resultado);
            }

            else if (valor1 != valor2)
            {
                resultado = valor1 * valor2;

                Console.WriteLine("A multiplicação dos valores foi de: " + resultado);
            }

            Console.ReadKey();
        }
    }
}

