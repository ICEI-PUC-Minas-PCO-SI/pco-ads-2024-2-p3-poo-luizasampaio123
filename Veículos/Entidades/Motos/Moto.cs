using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veículos.Entidades.Motos
{
    internal class Moto:Veiculo
    {
        private Motocross motoclass;
        private Scooter scotter;
        private bool garupa;

        public Moto(Motocross motoclass, Scooter scotter, bool garupa)
        {
            this.motoclass = motoclass;
            this.scotter = scotter;
            this.garupa = garupa;
        }

        public bool Garupa { get => garupa; set => garupa = value; }
        internal Motocross Motoclass { get => motoclass; set => motoclass = value; }
        internal Scooter Scotter { get => scotter; set => scotter = value; }

        public string quantGarupa()
        {
            if (garupa == true)
                return "possui";
            else
                return "não possui";
        }

        public override void mostrar() {
       

            Console.WriteLine($"A moto {quantGarupa()}  garupa ");
        
    }
    }
}
