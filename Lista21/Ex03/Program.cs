using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string n = Console.ReadLine();
            Console.Write("Email: ");
            string e = Console.ReadLine();
            Console.Write("Telefone: ");
            string f = Console.ReadLine();
            Cliente cliente = new Cliente(n, e, f);
            int op = Menu();
            while (op != 0)
            {
                if (op < 0 || op > 3) Console.WriteLine("Entrada inválida");
                switch (op)
                {
                    case 1: AdicionarConta(cliente); break;
                    // case 2: InserirEngenheiro(construtora); break;
                    case 3: ListarContas(cliente); break;
                }
                op = Menu();
            }
        }

        static void Banco(ContaBancaria cb)
        {
            int op = MenuBancario();
            while (op != 0)
            {
                if (op < 0 || op > 3) Console.WriteLine("Entrada inválida");
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o quanto quer depositar: ");
                        cb.Depositar(double.Parse(Console.ReadLine())); break;
                    case 2:
                        Console.WriteLine("Digite o saque: ");
                        cb.Sacar(double.Parse(Console.ReadLine())); break;
                    case 3:
                        Console.WriteLine($"Seu saldo é {cb.VerificarSaldo()}");
                        break;
                }
                op = MenuBancario();
            }
        }

        static int Menu()
        {
            Console.WriteLine("---------------- MENU --------------------");
            Console.WriteLine("[1] - Inserir conta bancária");
            Console.WriteLine("[2] - Remover conta bancária");
            Console.WriteLine("[3] - Listar as contas");
            Console.WriteLine("[0] - Finalizar");
            Console.WriteLine("------------------------------------------");
            int op = int.Parse(Console.ReadLine());
            Console.Clear();
            return op;
        }

        static void ListarContas(Cliente c)
        {
            Console.WriteLine("---------------- CONTAS ------------------");
            int i = 0;
            foreach (ContaBancaria cb in c.Listar())
            {
                Console.WriteLine($"[{i++}] - {cb}");
            }
            Console.WriteLine("------------------------------------------");
            int op = int.Parse(Console.ReadLine());
            Console.Clear();
            Banco(c.Listar()[op]);
        }

        static int MenuBancario()
        {
            Console.WriteLine("---------------- BANCO --------------------");
            Console.WriteLine("[1] - Depositar");
            Console.WriteLine("[2] - Sacar");
            Console.WriteLine("[3] - Verificar saldo");
            Console.WriteLine("[0] - Finalizar sessão");
            Console.WriteLine("------------------------------------------");
            int op = int.Parse(Console.ReadLine());
            Console.Clear();
            return op;
        }

        static void AdicionarConta(Cliente c)
        {
            Console.Write("Numero: ");
            string n = Console.ReadLine();
            Console.Write("Saldo: ");
            double s = double.Parse(Console.ReadLine());
            ContaBancaria cb = new ContaBancaria(n, s);
            c.Adicionar(cb);
        }
    }
}
