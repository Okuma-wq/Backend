using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Seja Bem Vindo!");
            Console.WriteLine("-------------------------------------");
            Console.Write("Por favor, informe a idade do candidato: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");

            if(idade < 5){
                Console.WriteLine("Desculpe, mas o candidato é muito novo para participar.");
            }
            if(idade >= 5 && idade <= 7){
                Console.WriteLine("O nadador foi aceito e colocado na categoria Infantil A");
                Console.WriteLine("Boa Sorte!");
            }
            if(idade >= 8 && idade <= 10){
                Console.WriteLine("O nadador foi aceito e colocado na categoria Infantil B");
                Console.WriteLine("Boa Sorte!");
            }
            if(idade >= 11 && idade <= 13){
                Console.WriteLine("O nadador foi aceito e colocado na categoria Juvenil A");
                Console.WriteLine("Boa Sorte!");
            }
            if(idade >= 14 && idade <= 17){
                Console.WriteLine("O nadador foi aceito e colocado na categoria Juvenil B");
                Console.WriteLine("Boa Sorte!");
            }
            if(idade >= 18){
                Console.WriteLine("O nadador foi aceito e colocado na categoria Sênior");
                Console.WriteLine("Boa Sorte!");
            }
        }
    }
}
