using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03
{
    class ContaBancaria
    {
        private string numero;
        private double saldo;
        public ContaBancaria(string n, double s)
        {
            numero = n;
            Depositar(s);
        }
        public void Depositar(double d)
        {
            if (d < 0) throw new ArgumentOutOfRangeException();
            saldo += d;
        }
        public void Sacar(double s)
        {
            if (s < 0) throw new ArgumentOutOfRangeException();
            if (saldo < s) throw new InversaoSaldoException();
            saldo -= s;
        }
        public double VerificarSaldo()
        {
            return saldo;
        }
        public override string ToString()
        {
            return $"{numero} - R$ {saldo}";
        }
    }
}
