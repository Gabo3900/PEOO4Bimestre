using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Veiculo
    {
        private string placa;
        private string fabricante;
        private string modelo;
        private int ano;
        private decimal preco;
        private bool vendido;
        public Veiculo(string p, string f, string m, int a, decimal pr)
        {
            placa = p;
            fabricante = f;
            modelo = m;
            ano = a;
            preco = pr;
        }
        public void Vender()
        {
            vendido = true;
        }
        public string GetPlaca()
        {
            return fabricante;
        }
        public string GetFabricante()
        {
            return fabricante;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public decimal GetPreco()
        {
            return preco;
        }
        public bool Vendido()
        {
            return vendido;
        }
    }
}
