using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas.Formas_geo
{
    internal class Triangulo : Formas
    {


        private double baseT;
        private double comprimento;


        public Triangulo(double baseT, double comprimento)
           : base(4, 4, 0, 0)
        {
            this.baseT = baseT;
            this.comprimento = comprimento;
        }
        public override double calcularPerimetro()
        {
            Perimetro = 2 * (baseT + comprimento);
            return Perimetro;
        }


        public override double calcularArea()
        {
            Area = (baseT * comprimento) / 2;
            return Area;
        }


        public override void setDimencao(double largura, double altura)
        {
            this.baseT = largura;
            this.comprimento = comprimento;
        }
    }
}

