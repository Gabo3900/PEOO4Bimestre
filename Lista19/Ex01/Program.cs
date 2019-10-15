using System;

namespace Ex01
{
    class Retangulo
    {
        private double b;
        private double h;
        public Retangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public double GetBase()
        {
            return b;
        }
        public double GetAltura()
        {
            return h;
        }
        public double CalcArea()
        {
            return b * h;
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt(b * b + h * h);
        }
        public override string ToString()
        {
            return $"{b} {h}";
        }
    }

    class Quadrado : Retangulo
    {
        public Quadrado(double l) : base(l, l) { }
        public override string ToString()
        {
            return $"{GetBase()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
