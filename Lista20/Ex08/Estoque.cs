using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class CompDescricao : IComparer<Produto>
    {
        public int Compare(Produto c1, Produto c2)
        {
            return c1.GetDescricao().CompareTo(c2.GetDescricao());
        }
    }

    class CompPreco : IComparer<Produto>
    {
        public int Compare(Produto c1, Produto c2)
        {
            return c1.GetPreco().CompareTo(c2.GetPreco());
        }
    }

    class Estoque
    {
        private List<Produto> produtos;
        public void Inserir(Produto p)
        {
            produtos.Add(p);
        }
        public void Excluir(Produto p)
        {
            produtos.Remove(p);
        }
        public List<Produto> ListarDescricao()
        {
            produtos.Sort(new CompDescricao());
            return produtos;
        }
        public List<Produto> ListarPreco()
        {
            produtos.Sort(new CompPreco());
            return produtos;
        }
        public Produto[] Vencidos()
        {
            List<Produto> vencidos = new List<Produto>();
            foreach(Produto p in produtos)
            {
                if (p.GetVencido()) vencidos.Add(p);
            }
            return vencidos.ToArray();
        }
        public Produto[] AVencer(int dias)
        {
            List<Produto> avencer = new List<Produto>();
            foreach (Produto p in produtos)
            {
                if (p.GetValidade() <= dias) avencer.Add(p);
            }
            return avencer.ToArray();
        }
        public Produto[] EstoqueBaixo(int minimo)
        {
            List<Produto> baixo = new List<Produto>();
            foreach (Produto p in produtos)
            {
                if (p.GetQtd() < minimo) baixo.Add(p);
            }
            return baixo.ToArray();
        }
        public decimal Total()
        {
            decimal total = 0;
            foreach(Produto p in produtos) { total += p.GetPreco(); }
            return total;
        }
    }
}
