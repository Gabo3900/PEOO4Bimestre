using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class CompFabricante : IComparer<Veiculo>
    {
        public int Compare(Veiculo v1, Veiculo v2)
        {
            if (v1.GetFabricante().CompareTo(v2.GetFabricante()) != 0)
            {
                return v1.GetFabricante().CompareTo(v2.GetFabricante());
            }
            return v1.GetModelo().CompareTo(v2.GetModelo());
        }
    }

    class CompModelo : IComparer<Veiculo>
    {
        public int Compare(Veiculo v1, Veiculo v2)
        {
            if (v1.GetModelo().CompareTo(v2.GetModelo()) != 0)
            {
                return v1.GetModelo().CompareTo(v2.GetModelo());
            }
            return v1.GetPreco().CompareTo(v2.GetPreco());
        }
    }

    class Loja
    {
        private string nome;
        private List<Veiculo> veiculos;
        public Loja(string n)
        {
            nome = n;
            veiculos = new List<Veiculo>();
        }
        public void Inserir(Veiculo v)
        {
            veiculos.Add(v);
        }
        public void Excluir(Veiculo v)
        {
            veiculos.Remove(v);
        }
        public Veiculo[] ListarPorFabricante()
        {
            veiculos.Sort(new CompFabricante());
            return veiculos.ToArray();
        }
        public Veiculo[] ListarPorModelo()
        {
            veiculos.Sort(new CompModelo());
            return veiculos.ToArray();
        }
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (Veiculo v in veiculos)
            {
                total += v.GetPreco();
            }
            return total;
        }
        public Veiculo BuscarPlaca(string p)
        {
            foreach (Veiculo v in veiculos)
            {
                if (v.GetPlaca() == p) return v;
            }
            return null;
        }
    }
}
