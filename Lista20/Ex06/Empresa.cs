using System;
using System.Collections.Generic;
using System.Text;

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
            foreach (Cliente c in clientes)
            {
                if (c.QtdSocio() == 0)
                {
                    ns.Add(c);
                }
            }
            return ns;
        }
    }
}
