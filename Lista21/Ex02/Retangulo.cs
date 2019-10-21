using System;
using System.Collections.Generic;
using System.Text;

namespace Ex02
{
    class Retangulo
    {
        private double b;
        private double h;
        public Retangulo(double b, double h)
        {
            Base = b;
            Altura = h;
        }
        public double Base
        {
            get
            {
                return b;
            }
            set
            {
                if (value >= 0) b = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public double Altura
        {
            get
            {
                return h;
            }
            set
            {
                if (value >= 0) h = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public double GetArea()
        {
            return Base * Altura;
        }
        public override string ToString()
        {
            return $"{Base} x {Altura}";
        }
    }
}
