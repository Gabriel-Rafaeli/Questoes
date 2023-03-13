namespace Questao9.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Digite o número de notas do aluno: ");
            int numNotas = int.Parse(Console.ReadLine());

            double somaInversosNotas = 0;

            for (int i = 1; i <= numNotas; i++)
            {
                Console.Write($"Digite a nota {i}: ");
                double nota = double.Parse(Console.ReadLine());
                somaInversosNotas += 1.0 / nota;
            }

            double mediaHarmonica = numNotas / somaInversosNotas;

            Console.WriteLine($"A média harmônica das notas é: {mediaHarmonica:F2}");
        }
    }
}