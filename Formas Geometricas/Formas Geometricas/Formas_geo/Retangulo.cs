﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas.Formas_geo
{
    internal class Retangulo : Formas
    {
        
        private double largura;
        private double comprimento;


       public Retangulo(double largura, double comprimento)
          : base(4, 4, 0, 0) 
        {
            this.largura = largura;
            this.comprimento = comprimento;
        }
        public override double calcularPerimetro()
        {
            Perimetro = 2 * (largura + comprimento); 
            return Perimetro;
        }

  
        public override double calcularArea()
        {
            Area = largura * comprimento; 
            return Area;
        }

        public override void setDimencao(double largura, double altura)
        {
            this.largura = largura;
            this.comprimento = comprimento;
        }
    }
}
