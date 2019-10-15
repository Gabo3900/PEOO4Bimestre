using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string n = Console.ReadLine();
            Console.Write("Telefone: ");
            string f = Console.ReadLine();
            Usuario usuario = new Usuario(n, f);
            int op = Menu();
            while (op != 0)
            {
                if (op < 0 || op > 4) Console.WriteLine("Entrada inválida");
                switch (op)
                {
                    case 1: InserirContato(usuario); break;
                    case 2: InserirGrupo(usuario); break;
                    case 3: ListarContato(usuario); break;
                    case 4: ListarGrupo(usuario); break;
                }
                op = Menu();
            }
        }

        static int Menu()
        {
            Console.WriteLine("---------------- MENU --------------------");
            Console.WriteLine("[1] - Cadastrar contato");
            Console.WriteLine("[2] - Cadastrar grupo");
            Console.WriteLine("[3] - Listar contatos");
            Console.WriteLine("[4] - Listar grupos");
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
            Grupo(u, g);
            u.InserirGrupo(g);
        }

        static void ListarContato(Usuario u)
        {
            foreach (Contato c in u.ListarContatos())
            {
                Console.WriteLine(c);
            }
        }

        static void ListarGrupo(Usuario u)
        {
            int i = 1;
            foreach (Grupo g in u.ListarGrupos())
            {
                Console.WriteLine($"[{i++}] - {g}");
            }
            int op = int.Parse(Console.ReadLine());
            Grupo(u, u.ListarGrupos()[op]);
        }

        static void Grupo(Usuario u, Grupo g)
        {
            int op = MenuGrupo();
            while (op != 0)
            {
                if (op < 0 || op > 3) Console.WriteLine("Entrada inválida");
                switch (op)
                {
                    case 1: g.Adicionar(SelecionarContato(u)); break;
                    case 2: ExcluirContato(g); break;
                    case 3: foreach (Contato c in g.ListarContatos()) Console.WriteLine(c); break;
                }
                op = MenuGrupo();
            }
        }

        static int MenuGrupo()
        {
            Console.WriteLine("---------------- Grupo --------------------");
            Console.WriteLine("[1] - Adicionar contato");
            Console.WriteLine("[2] - Excluir contato");
            Console.WriteLine("[3] - Listar contatos");
            Console.WriteLine("[0] - Salvar");
            Console.WriteLine("------------------------------------------");
            int op = int.Parse(Console.ReadLine());
            Console.Clear();
            return op;
        }

        static Contato SelecionarContato(Usuario u)
        {
            int i = 0;
            foreach (Contato c in u.ListarContatos())
            {
                Console.WriteLine($"[{i++}] - {c}");
            }
            int op = int.Parse(Console.ReadLine());
            return u.ListarContatos()[op];
        }

        static void ExcluirContato(Grupo g)
        {
            int i = 0;
            foreach (Contato c in g.ListarContatos())
            {
                Console.WriteLine($"[{i++}] - {c}");
            }
            int op = int.Parse(Console.ReadLine());
            g.Excluir(g.ListarContatos()[op]);
        }
    }
}
