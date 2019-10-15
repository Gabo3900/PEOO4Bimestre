using System;

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
            return $"{base.ToString()}";
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

    class Contato
    {
        private string nome;
        private string fone;
        public Contato(string n, string f)
        {
            nome = n;
            fone = f;
        }
        public override string ToString()
        {
            return $"{nome} {fone}";
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
