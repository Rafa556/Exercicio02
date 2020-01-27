using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício02
{
    class Carro : Veiculo
    {
        private String marca { get; set; }
        private int portas { get; set; }
        private int ano { get; set; }

        public Carro(string modelo, int velocidade, int passageiro, float combustivel, string marca, int portas, int ano)
        {
            this.marca = marca;
            this.portas = portas;
            this.ano = ano;
        }

        public void status()
        {
            base.status();
            Console.WriteLine("A marca do carro é :" + this.marca);
            Console.WriteLine("A quantidade de portas são: " + this.portas);
            Console.WriteLine("O ano do carro é " + this.ano);

        }
    }
}
