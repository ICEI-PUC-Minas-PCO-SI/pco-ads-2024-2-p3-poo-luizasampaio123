using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas.Formas_geo
{
    internal abstract class Formas
    {
        private int lados;
        private int vertices;
        private double area;
        private double perimetro;
  
        public Formas(int lados, int vertices, double area, double perimetro)
        {
            this.Lados = lados;
            this.Vertices = vertices;
            this.Area = area;
            this.Perimetro = perimetro;
           
        }

        public int Lados { get => lados; set => lados = value; }
        public int Vertices { get => vertices; set => vertices = value; }
        public double Area { get => area; set => area = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }

        public abstract void setDimencao(double largura, double altura);

        public abstract double calcularPerimetro();

        public abstract double calcularArea();



   }
}
