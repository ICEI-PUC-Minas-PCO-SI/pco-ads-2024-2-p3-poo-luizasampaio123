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
            label_raio.Visible = false;
            text_raio.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            formaSelecionada = new Quadrados();

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Quadrados r = new Quadrados();


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
            formaSelecionada = new Hexagono();

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Hexagono r = new Hexagono();


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
            formaSelecionada = new Octagono();

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Octagono r = new Octagono();


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
            double largura;
            double raio;
            double altura;
            formaSelecionada = new Circulo(0);
            label_raio.Visible = true;
            text_raio.Visible = true;
            


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura)&& double.TryParse(text_raio.Text, out raio))
            {

                Circulo c = new Circulo(raio);


                double area = c.calcularArea();
                double perimetro = c.calcularPerimetro();

            }
            else
            {

                MessageBox.Show("Digite valores válidos para a largura e a altura.");
            }
        }

        private void btnRegangulo_Click(object sender, EventArgs e)
        {
            formaSelecionada = new Retangulo();

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Retangulo r = new Retangulo();


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
            formaSelecionada = new Triangulo();

            double largura;
            double altura;


            if (double.TryParse(input_larg.Text, out largura) && double.TryParse(input_altura.Text, out altura))
            {

                Retangulo r = new Retangulo();


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

                Pentagono r = new Pentagono();


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


                    
                    MessageBox.Show($"A área de sua forma é: {area:f2} e o perimetro {perimetro:f2} ");

                   
                }

            }
            else
            {
                MessageBox.Show("Digite valores válidos para a largura e a altura.");
            }
        }

        private void text_raio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_raio_Click(object sender, EventArgs e)
        {

        }
    }
}
