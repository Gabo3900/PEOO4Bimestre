using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03
{
    class Cliente
    {
        private string nome;
        private string email;
        private string fone;
        private List<ContaBancaria> contas;
        public Cliente(string n, string e, string f)
        {
            nome = n;
            email = e;
            fone = f;
            contas = new List<ContaBancaria>();
        }
        public void Adicionar(ContaBancaria c)
        {
            contas.Add(c);
        }
        public void Remover(ContaBancaria c)
        {
            contas.Remove(c);
        }
        public List<ContaBancaria> Listar()
        {
            return contas;
        }
        public override string ToString()
        {
            return $"{nome} {email} {fone}";
        }
    }
}
