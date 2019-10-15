using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class Produto
    {
        private string descricao;
        private decimal preco;
        private int qtd;
        private DateTime validade;
        public Produto(string d, decimal p, int q, DateTime v)
        {
            descricao = d;
            if(p >= 0) preco = p;
            if(q >= 0) qtd = q;
            validade = v;
        }
        public string GetDescricao() { return descricao; }
        public decimal GetPreco() { return preco; }
        public int GetQtd() { return qtd; }
        public int GetValidade() { return (validade - DateTime.Today).Days; }
        public bool GetVencido()
        {
            if (validade > DateTime.Today) return true;
            return false;
        }
    }
}
