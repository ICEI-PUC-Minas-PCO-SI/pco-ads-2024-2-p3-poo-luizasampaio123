namespace Formas_Geometricas
{
    partial class btn_teste
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnQuadrado = new Button();
            btnHexagono = new Button();
            btnOctagono = new Button();
            btnPentagono = new Button();
            btnCirculo = new Button();
            btnRegangulo = new Button();
            Triangulo = new Button();
            label1 = new Label();
            label2 = new Label();
            input_altura = new TextBox();
            input_larg = new TextBox();
            label3 = new Label();
            button1 = new Button();
            text_raio = new TextBox();
            label_raio = new Label();
            SuspendLayout();
            // 
            // btnQuadrado
            // 
            btnQuadrado.Location = new Point(127, 149);
            btnQuadrado.Name = "btnQuadrado";
            btnQuadrado.Size = new Size(287, 75);
            btnQuadrado.TabIndex = 1;
            btnQuadrado.Text = "Quadrado";
            btnQuadrado.UseVisualStyleBackColor = true;
            btnQuadrado.Click += btnQuadrado_Click;
            // 
            // btnHexagono
            // 
            btnHexagono.Location = new Point(127, 257);
            btnHexagono.Name = "btnHexagono";
            btnHexagono.Size = new Size(287, 75);
            btnHexagono.TabIndex = 2;
            btnHexagono.Text = "Hexagono";
            btnHexagono.UseVisualStyleBackColor = true;
            btnHexagono.Click += btnHexagono_Click;
            // 
            // btnOctagono
            // 
            btnOctagono.Location = new Point(127, 375);
            btnOctagono.Name = "btnOctagono";
            btnOctagono.Size = new Size(287, 75);
            btnOctagono.TabIndex = 3;
            btnOctagono.Text = "Octagono";
            btnOctagono.UseVisualStyleBackColor = true;
            btnOctagono.Click += btnOctagono_Click;
            // 
            // btnPentagono
            // 
            btnPentagono.Location = new Point(453, 375);
            btnPentagono.Name = "btnPentagono";
            btnPentagono.Size = new Size(287, 75);
            btnPentagono.TabIndex = 4;
            btnPentagono.Text = "Pentagono";
            btnPentagono.UseVisualStyleBackColor = true;
            btnPentagono.Click += btnPentagono_Click;
            // 
            // btnCirculo
            // 
            btnCirculo.Location = new Point(127, 477);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(287, 75);
            btnCirculo.TabIndex = 5;
            btnCirculo.Text = "Circulo";
            btnCirculo.UseVisualStyleBackColor = true;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // btnRegangulo
            // 
            btnRegangulo.Location = new Point(453, 149);
            btnRegangulo.Name = "btnRegangulo";
            btnRegangulo.Size = new Size(287, 75);
            btnRegangulo.TabIndex = 6;
            btnRegangulo.Text = "Retangulo";
            btnRegangulo.UseVisualStyleBackColor = true;
            btnRegangulo.Click += btnRegangulo_Click;
            // 
            // Triangulo
            // 
            Triangulo.Location = new Point(453, 257);
            Triangulo.Name = "Triangulo";
            Triangulo.Size = new Size(287, 75);
            Triangulo.TabIndex = 7;
            Triangulo.Text = "Triangulo";
            Triangulo.UseVisualStyleBackColor = true;
            Triangulo.Click += Triangulo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(256, 35);
            label1.Name = "label1";
            label1.Size = new Size(315, 46);
            label1.TabIndex = 8;
            label1.Text = "Selecione as formas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(909, 120);
            label2.Name = "label2";
            label2.Size = new Size(246, 32);
            label2.TabIndex = 9;
            label2.Text = "Digite o valor do lado";
            label2.Click += label2_Click;
            // 
            // input_altura
            // 
            input_altura.Location = new Point(909, 188);
            input_altura.Name = "input_altura";
            input_altura.Size = new Size(442, 27);
            input_altura.TabIndex = 17;
            // 
            // input_larg
            // 
            input_larg.Location = new Point(911, 324);
            input_larg.Name = "input_larg";
            input_larg.Size = new Size(442, 27);
            input_larg.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(909, 256);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 10;
            label3.Text = "Digite a largura:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(973, 375);
            button1.Name = "button1";
            button1.Size = new Size(287, 75);
            button1.TabIndex = 22;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // text_raio
            // 
            text_raio.Location = new Point(1467, 188);
            text_raio.Name = "text_raio";
            text_raio.Size = new Size(442, 27);
            text_raio.TabIndex = 23;
            text_raio.TextChanged += text_raio_TextChanged;
            // 
            // label_raio
            // 
            label_raio.AutoSize = true;
            label_raio.Font = new Font("Segoe UI", 14F);
            label_raio.Location = new Point(1558, 120);
            label_raio.Name = "label_raio";
            label_raio.Size = new Size(240, 32);
            label_raio.TabIndex = 24;
            label_raio.Text = "Digite o valor do raio";
            label_raio.Click += label_raio_Click;
            // 
            // btn_teste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2003, 818);
            Controls.Add(label_raio);
            Controls.Add(text_raio);
            Controls.Add(button1);
            Controls.Add(input_altura);
            Controls.Add(input_larg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Triangulo);
            Controls.Add(btnRegangulo);
            Controls.Add(btnCirculo);
            Controls.Add(btnPentagono);
            Controls.Add(btnOctagono);
            Controls.Add(btnHexagono);
            Controls.Add(btnQuadrado);
            Name = "btn_teste";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnQuadrado;
        private Button btnHexagono;
        private Button btnOctagono;
        private Button btnPentagono;
        private Button btnCirculo;
        private Button btnRegangulo;
        private Button Triangulo;
        private Label label1;
        private Label label2;
        private TextBox input_altura;
        private TextBox input_larg;
        private Label label3;
        
        private Button button1;
        private TextBox text_raio;
        private Label label_raio;
    }
}
