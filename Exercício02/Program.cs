using System;

namespace Exercício02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Carro c1 = new Carro("Camaro", 100, 4, 100, "Chevrolet", 2, 2016);
            c1.status();
            Console.WriteLine("---------------------------");
            Avião a1 = new Avião("Viagem", "Pessoas", "Emirates", 300, 100, 400);
            a1.status();
        }
    }
}
