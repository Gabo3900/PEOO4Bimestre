using System;

namespace Ex02
{
    class Frete
    {
        private double distancia;
        private double peso;
        public Frete(double d, double p)
        {
            distancia = d;
            peso = p;
        }
        public virtual decimal CalcFrete()
        {
            return (decimal) (0.01 * peso * distancia);
        }
        public override string ToString()
        {
            return $"{distancia} {peso}";
        }
    }

    class FreteExpresso : Frete
    {
        private decimal seguro;
        public FreteExpresso(double d, double p, decimal s) : base(d, p)
        {
            seguro = s;
        }
        public override decimal CalcFrete()
        {
            return base.CalcFrete() * 2 + seguro / 100;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {seguro}";
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
