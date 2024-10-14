using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas.Formas_geo
{
    internal class Triangulo : Formas
    {





        public Triangulo(
)
           : base(3, 3, 0, 0,0,0)
        {
 
        }
        public override double calcularPerimetro()
        {
            Perimetro = 2 * (Largura + Altura);
            return Perimetro;
        }


        public override double calcularArea()
        {
            Area = (Largura * Altura) / 2;
            return Area;
        }


        public override void setDimencao(double largura, double altura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }
    }
}

