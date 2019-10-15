using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int Menu()
        {
            Console.WriteLine("---------------- MENU --------------------");
            Console.WriteLine("[1] - Cadastrar contato");
            Console.WriteLine("[2] - Cadastrar grupo");
            Console.WriteLine("[4] - Listar contatos");
            Console.WriteLine("[5] - Listar grupos");
            Console.WriteLine("[0] - Finalizar");
            Console.WriteLine("------------------------------------------");
            int op = int.Parse(Console.ReadLine());
            Console.Clear();
            return op;
        }

        static void InserirContato(Usuario u)
        {
            Console.Write("Nome: ");
            string n = Console.ReadLine();
            Console.Write("Telefone: ");
            string f = Console.ReadLine();
            Contato c = new Contato(n, f);
            u.InserirContato(c);
        }

        static void InserirGrupo(Usuario u)
        {
            Console.WriteLine("Descrição: ");
            Grupo g = new Grupo(Console.ReadLine());
            u.InserirGrupo(g);
        }


    }
}
