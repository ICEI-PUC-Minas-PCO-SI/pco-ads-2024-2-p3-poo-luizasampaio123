using Formas_Geometricas.Formas_geo;

namespace Formas_Geometricas
{
    public partial class btn_teste : Form
    {

        private Formas formaSelecionada;
        public btn_teste()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            formaSelecionada = new Quadrados(0, 0);

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Retangulo r = new Retangulo(largura, altura);


                double area = r.calcularArea();
                double perimetro = r.calcularPerimetro();
;
            }
            else
            {

                MessageBox.Show("Digite valores válidos para a largura e a altura.");
            }

        }

        private void btnHexagono_Click(object sender, EventArgs e)
        {
            formaSelecionada = new Hexagono(0, 0);

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Retangulo r = new Retangulo(largura, altura);


                double area = r.calcularArea();
                double perimetro = r.calcularPerimetro();

                
            }
            else
            {

                MessageBox.Show("Digite valores válidos para a largura e a altura.");
            }
        }

        private void btnOctagono_Click(object sender, EventArgs e)
        {
            formaSelecionada = new Octagono(0, 0);

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Retangulo r = new Retangulo(largura, altura);


                double area = r.calcularArea();
                double perimetro = r.calcularPerimetro();

                
            }
            else
            {

                MessageBox.Show("Digite valores válidos para a largura e a altura.");
            }
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circulo c = new Circulo();

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Retangulo r = new Retangulo(largura, altura);


                double area = r.calcularArea();
                double perimetro = r.calcularPerimetro();

                
            }
            else
            {

                MessageBox.Show("Digite valores válidos para a largura e a altura.");
            }
        }

        private void btnRegangulo_Click(object sender, EventArgs e)
        {
            formaSelecionada = new Retangulo(0, 0);

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Retangulo r = new Retangulo(largura, altura);


                double area = r.calcularArea();
                double perimetro = r.calcularPerimetro();

                
            }
            else
            {

                MessageBox.Show("Digite valores válidos para a largura e a altura.");
            }
        }

        private void Triangulo_Click(object sender, EventArgs e)
        {
            formaSelecionada = new Triangulo(0, 0);

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Retangulo r = new Retangulo(largura, altura);


                double area = r.calcularArea();
                double perimetro = r.calcularPerimetro();

               
            }
            else
            {

                MessageBox.Show("Digite valores válidos para a largura e a altura.");
            }


        }

        private void btnPentagono_Click(object sender, EventArgs e)
        {

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Retangulo r = new Retangulo(largura, altura);


                double area = r.calcularArea();
                double perimetro = r.calcularPerimetro();

                
            }
            else
            {

                MessageBox.Show("Digite valores válidos para a largura e a altura.");
            }
        }







        private void btn_perimetro_Click(object sender, EventArgs e)
        {

        }

        private void btn_area_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_per_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            double largura, altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {
                if (formaSelecionada != null)
                {
                    formaSelecionada.setDimencao(largura, altura);

                    double area = formaSelecionada.calcularArea();
                    double perimetro = formaSelecionada.calcularPerimetro();

                    

                    MessageBox.Show($"A área de sua forma é: {area} e o perimetro {perimetro} ");
                }

            }
            else
            {
                MessageBox.Show("Digite valores válidos para a largura e a altura.");
            }
        }
    }
}
