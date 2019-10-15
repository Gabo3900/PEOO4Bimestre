using System;

namespace Ex03
{
    class ContaCorrente
    {
        private string titular;
        private string numeroConta;
        protected double saldo;
        public ContaCorrente(string t, string n)
        {
            titular = t;
            numeroConta = n;
        }
        public void Depositar(double valor) { saldo += valor; }
        public virtual bool Sacar(double valor)
        {
            if (saldo < valor) return false;
            saldo -= valor;
            return true;
        }
        public double RetornarSaldo() { return saldo; }
        public override string ToString()
        {
            return $"{titular} {numeroConta} {saldo}";
        }
    }

    class ContaEspecial : ContaCorrente
    {
        private double limite;
        public ContaEspecial(string t, string n, double l) : base(t, n)
        {
            limite = l;
        }
        public override bool Sacar(double valor)
        {
            if (saldo < limite + valor) return false;
            saldo -= valor;
            return true;
        }
    }

    class Poupança : ContaCorrente
    {
        public Poupança(string t, string n) : base(t, n) { }
        public void Render(double juros)
        {
            saldo += juros;
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
