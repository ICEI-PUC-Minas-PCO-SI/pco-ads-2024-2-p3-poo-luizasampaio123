using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas.Formas_geo
{
    internal class Pentagono:Formas
    {
        public Pentagono()
           : base(5, 5, 0, 0, 0, 0)
        {
            this.Largura = Largura;
            this.Altura = Altura;
        }
        public override double calcularPerimetro()
        {
            Perimetro = 2 * (Largura + Altura);
            return Perimetro;
        }


        public override double calcularArea()
        {
            Area = Largura * Altura;
            return Area;
        }

        public override void setDimencao(double largura, double altura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }
    }
}
