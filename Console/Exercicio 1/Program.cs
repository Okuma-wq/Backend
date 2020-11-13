using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem vindo!");
            Console.Write("Por favor, digite a sua idade em anos: ");
            
            int anos = int.Parse(Console.ReadLine());

            int meses = (anos * 12);

            int dias = (anos * 365);

            int horas = (dias * 24);

            int minutos = (horas * 60);

        
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("sua idade em meses: " + meses );
            Console.WriteLine("sua idade em dias: " + dias );
            Console.WriteLine("sua idade em horas: " + horas );
            Console.WriteLine("sua idade em minutos: " + minutos );

        }
    }
}
