using System;
using System.Collections.Generic;

namespace Ex06
{
    class CompNome : IComparer<Cliente>
    {
        public int Compare(Cliente c1, Cliente c2)
        {
            return c1.GetNome().CompareTo(c2.GetNome());
        }
    }

    class CompLimite : IComparer<Cliente>
    {
        public int Compare(Cliente c1, Cliente c2)
        {
            return c1.LimiteTotal.CompareTo(c2.LimiteTotal);
        }
    }

    class Cliente
    {
        private string nome;
        private string cpf;
        private decimal limite;
        private List<Cliente> socio;
        public Cliente(string n, string c, decimal l)
        {
            nome = n;
            cpf = c;
            limite = l;
            socio = new List<Cliente>();
        }
        public string GetNome()
        {
            return nome;
        }
        public int QtdSocio()
        {
            return socio.Count;
        }
        public decimal LimiteTotal
        {
            get
            {
                decimal lt = 0;
                foreach (Cliente c in socio)
                {
                    lt += c.limite;
                }
                return limite + lt;
            }
        }
        public void Inserir(Cliente c)
        {
            socio.Add(c);
        }
        public void Excluir(Cliente c)
        {
            socio.Remove(c);
        }
    }

    class Empresa
    {
        private List<Cliente> clientes;
        public void Inserir(Cliente c)
        {
            clientes.Add(c);
        }
        public void Excluir(Cliente c)
        {
            clientes.Remove(c);
        }
        public void Socios(Cliente x, Cliente y)
        {
            x.Inserir(y);
            y.Inserir(x);
        }
        public List<Cliente> ListarNome()
        {
            clientes.Sort(new CompNome());
            return clientes;
        }
        public List<Cliente> ListarLimite()
        {
            clientes.Sort(new CompLimite());
            return clientes;
        }
        public List<Cliente> ListarNaoSocio()
        {
            List<Cliente> ns = new List<Cliente>();
            foreach(Cliente c in clientes)
            {
                if(c.QtdSocio() == 0)
                {
                    ns.Add(c);
                }
            }
            return ns;
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
