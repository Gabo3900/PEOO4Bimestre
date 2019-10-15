using System;
using System.Collections.Generic;
using System.Text;

namespace Ex05
{
    class Usuario : Contato
    {
        private Contato[] contatos;
        private Grupo[] grupos;
        private int k, j;
        private int kmax;
        public Usuario(string n, string f) : base(n, f)
        {
            kmax = 2;
            contatos = new Contato[kmax];
            grupos = new Grupo[100];
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {k} contatos - {j} grupos";
        }
        public void InserirContato(Contato c)
        {
            if (k < kmax) contatos[k++] = c;
            else
            {
                kmax = 2 * kmax;
                Contato[] cts = new Contato[kmax];
                Array.Copy(contatos, cts, k);
                contatos = cts;
                contatos[k++] = c;
            }
        }
        public void InserirGrupo(Grupo g)
        {
            if (j < 100) grupos[j++] = g;
        }
        public Contato[] ListarContatos()
        {
            Contato[] novo = new Contato[k];
            Array.Copy(contatos, novo, k);
            return novo;
        }
        public Grupo[] ListarGrupos()
        {
            Grupo[] novo = new Grupo[j];
            Array.Copy(grupos, novo, j);
            return novo;
        }
    }
}
