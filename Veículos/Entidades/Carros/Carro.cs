using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veículos.Entidades.Serviços;

namespace Veículos.Entidades.Carros
{
    internal class Carro:Veiculo
    {
        private int quantjanelas;
        private int quantPortas;
        private Picape picape;
        private Sedan sedan;
        private Seguro seguro;

        public Carro(int quantjanelas, int quantPortas, Picape picape, Sedan sedan, Seguro seguro)
        {
            this.quantjanelas = quantjanelas;
            this.quantPortas = quantPortas;
            this.picape = null;
            this.sedan = null;
            this.seguro = seguro;
        }

        public int Quantjanelas { get => quantjanelas; set => quantjanelas = value; }
        public int QuantPortas { get => quantPortas; set => quantPortas = value; }
        internal Picape Picape { get => picape; set => picape = value; }
        internal Sedan Sedan { get => sedan; set => sedan = value; }
        internal Seguro Seguro { get => seguro; set => seguro = value; }

        public override void mostrar() {

            Console.WriteLine($"A quantidade de janelas é {quantjanelas} e a de portas é {quantPortas} ");
        }
    }

    
}
