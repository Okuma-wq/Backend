using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Seja Bem Vindo!");
            Console.Write("Por favor, informe o seu ano de nascimento: ");
            int anoDeNascimento = int.Parse(Console.ReadLine());
            Console.Write("Por favor, informe o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());


            int idade = anoAtual - anoDeNascimento;

            int idadeEmSemanas = idade * 52;

            Console.WriteLine("-----------------------");
            Console.WriteLine("Sua idade é de " + idade + " anos ou de " + idadeEmSemanas + " semanas");         
       }
    }
}
