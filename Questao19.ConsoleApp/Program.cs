namespace Questao19.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;

            Console.WriteLine("digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("digite sua altura: ");
            altura = double.Parse(Console.ReadLine());


            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("você está abaixo do peso");
            }

            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("você está com peso normal");
            }

            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("você está acima do peso");
            }

            else if (imc > 30)
            {
                Console.WriteLine("você está obeso");
            }

            Console.ReadKey();
        }
    }
} 

