using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veículos.Entidades.Carros;
using Veículos.Entidades.Motos;

namespace Veículos.Entidades
{
    internal class Veiculo
    {
        private string placa;
        private string renacam;
        private Carro carro;
        private Moto moto;

        public virtual void mostrar() { }
    }
}
