using System;
using System.Collections.Generic;

namespace Ex04
{
    class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }
    }

    class Agenda
    {
        private List<Contato> cs = new List<Contato>();
        public void Inserir(Contato c)
        {
            cs.Add(c);
        }
        public List<Contato> Listar()
        {
            return cs;
        }
        public List<Contato> Pesquisar(string p)
        {
            List<Contato> pesquisa = new List<Contato>();
            foreach (Contato c in cs)
            {
                if (c.Nome.Contains(p)) pesquisa.Add(c);
            }
            return pesquisa;
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
