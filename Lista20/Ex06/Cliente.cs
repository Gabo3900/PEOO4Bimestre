using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06
{
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
}
