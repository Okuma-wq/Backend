using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Por favor, Informe seu salário atual: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 500) {
                double novoSalario = salario + salario*30/100;
                Console.Write("Seu salário reajustado é de: " + novoSalario.ToString("C"));
            } else{
                Console.WriteLine("Seu salário é igual ou superior a 500 reais e portanto não recebera aumento");
            }
        }
    }
}
