using System;

namespace Semáforo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cor da luz acesa no semaforo: ");
            string cor = Console.ReadLine();

            string açao = "";

            if (cor == "vermelho") {
                    açao = "Pare";
            }

            if (cor == "amarelo") {
                    açao = "Reduza a velocidade e pare";
            }

            if (cor == "verde") {
                    açao = "Continue acelerando ou mantenha a velocidade atual";
            }

            Console.Write(açao);
        }
    }
}
