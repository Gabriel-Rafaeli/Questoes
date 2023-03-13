using System;

namespace Questao1.ConsoleApp
{
    //Questão 1

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Informe o comprimento da caixa em metros: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a largura da caixa em metros: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a altura da caixa em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = comprimento * largura * altura;

            Console.WriteLine("O volume da caixa é: " + volume + " metros cúbicos.");
        }
    }
}