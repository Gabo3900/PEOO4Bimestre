using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05
{
    class Grupo
    {
        private string descricao;
        private Contato[] contatos;
        private int k;
        public Grupo(string d)
        {
            descricao = d;
            contatos = new Contato[100];
        }
        public void Adicionar(Contato c)
        {
            if (k < 100) contatos[k++] = c;
        }
        public void Excluir(Contato c)
        {
            int p = Array.IndexOf(contatos, c);
            for (int i = p + 1; i < k; i++)
                contatos[i - 1] = contatos[i];
            k--;
        }
        public Contato[] ListarContatos()
        {
            Contato[] c = new Contato[k];
            Array.Copy(contatos, c, k);
            return c;
        }
        public override string ToString()
        {
            return $"{descricao} - {k} contato(s)";
        }
    }
}
