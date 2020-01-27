using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício02
{
    public abstract class Veiculo
    {
        private String modelo { get; set; }
        private int velocidade { get; set; }
        private int passageiros { get; set; }
        private float combustivel { get; set; }

        public Veiculo(String modelo, int velocidade, int passageiros, float combustivel)
        {
            this.modelo = modelo;
            this.velocidade = velocidade;
            this.passageiros = passageiros;
            this.combustivel = combustivel;
        }

        public Veiculo() {
        }

        public void status()
        {
            Console.WriteLine("Modelo do veiculo:" + this.modelo);
            Console.WriteLine("Velocidade do veiculo" + this.velocidade +"Km/h");
            Console.WriteLine("O número de passageiros é: " + this.passageiros + "passageiros");
            Console.WriteLine("A quantidae de combustivel é: " + this.combustivel +" Litros");
        }
    }
}
