namespace Questao29.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 10;

            for (int i = 1; i <= max; i++)
            {
                for (int o = 1; o <= max; o++)
                {
                    double resultado = i * o;

                    Console.Write("{0,2} x {1,2} = {2,3}   ", i, o, resultado);
                }

                Console.WriteLine();
            }
        }
    }
}