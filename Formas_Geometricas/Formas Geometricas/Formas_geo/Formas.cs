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
        private double largura;
        private double altura;

        public int Lados { get => lados; set => lados = value; }
        public int Vertices { get => vertices; set => vertices = value; }
        public double Area { get => area; set => area = value; }
        public double Perimetro { get => perimetro; set => perimetro = value; }
        public double Largura { get => largura; set => largura = value; }
        public double Altura { get => altura; set => altura = value; }

        protected Formas(int lados, int vertices, double area, double perimetro, double largura, double altura)
        {
            this.Lados = lados;
            this.Vertices = vertices;
            this.Area = area;
            this.Perimetro = perimetro;
            this.Largura = largura;
            this.Altura = altura;
        }

        public abstract void setDimencao(double Largura, double Altura);

        public abstract double calcularPerimetro();

        public abstract double calcularArea();



   }
}
