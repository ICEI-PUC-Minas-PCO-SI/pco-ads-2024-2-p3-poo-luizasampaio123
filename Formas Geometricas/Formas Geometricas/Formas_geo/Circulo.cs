using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas.Formas_geo
{
    internal sealed class Circulo
    {
        public double raio { get; set; }
        public Circulo() { }
        public Circulo(double _raio)
        {
            this.raio = _raio;
        }

        public double CalcularArea(double raio)
        {
            return Math.PI * raio * raio;
        }

        
    }
}
