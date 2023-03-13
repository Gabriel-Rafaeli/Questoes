namespace Questao7.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o salário base do vendedor: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Informe o total de vendas do vendedor: ");
            double totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Informe a comissão a ser aplicada sobre as vendas (em %): ");
            double comissao = double.Parse(Console.ReadLine());

            double salarioTotal = salarioBase + (totalVendas * (comissao * salarioBase / 100));

            Console.WriteLine("O salário total do vendedor é: R$ " + salarioTotal);
        }
    }
}