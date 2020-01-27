using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício02
{
    class Avião : Veiculo
    {
        private String tipo { get; set; }
        private String uso { get; set; }

        public Avião(String tipo, String uso, String modelo, int velocidade, int passageiros, float combustivel) {

            this.tipo = tipo;
            this.uso = uso;
        }
        public void status()
        {
            base.status();
            Console.WriteLine("O tipo do avião é: " + this.tipo);
            Console.WriteLine("O uso do avião é: " + this.uso);
        }
    }
}
