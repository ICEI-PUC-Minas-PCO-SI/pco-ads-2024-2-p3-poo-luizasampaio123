namespace Formas_Geometricas.Formas_geo
{
    internal sealed class Circulo : Formas


    {
        public double raio { get; set; }

        public Circulo(double raio
)
           : base(0, 0, 0, 0)
        {
            this.raio = raio;
        }




        public override double calcularArea()
        {
            return Math.PI * raio * raio;
        }

        public override double calcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }


        public override void setDimencao(double largura, double altura)
        {

            this.raio = largura / 2;
        }


    }

}

