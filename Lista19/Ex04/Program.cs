using System;
using System.Collections.Generic;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Construtora construtora = new Construtora();
            int op = Menu();
            while (op != 0)
            {
                if (op < 0 || op > 6) Console.WriteLine("Entrada inválida");
                switch (op)
                {
                    case 1: InserirFuncionario(construtora); break;
                    case 2: InserirEngenheiro(construtora); break;
                    case 3: InserirMotorista(construtora); break;
                    case 4: foreach (Funcionario f in construtora.Funcionarios()) Console.WriteLine(f); break;
                    case 5: foreach (Engenheiro e in construtora.Engenheiros()) Console.WriteLine(e); break;
                    case 6: foreach (Motorista m in construtora.Motoristas()) Console.WriteLine(m); break;
                }
                op = Menu();
            }
        }

        static int Menu()
        {
            Console.WriteLine("---------------- MENU --------------------");
            Console.WriteLine("[1] - Inserir um funcionario");
            Console.WriteLine("[2] - Inserir um engenheiro");
            Console.WriteLine("[3] - Inserir um motorista");
            Console.WriteLine("[4] - Listar os funcionarios");
            Console.WriteLine("[5] - Listar os engenheiros");
            Console.WriteLine("[6] - Listar os motorista");
            Console.WriteLine("[0] - Finalizar");
            Console.WriteLine("------------------------------------------");
            int op = int.Parse(Console.ReadLine());
            Console.Clear();
            return op;
        }

        static void InserirFuncionario(Construtora c)
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("Digite o nome do funcionario: ");
            f.SetNome(Console.ReadLine());
            Console.WriteLine("Digite o e-mail do funcionario: ");
            f.SetEmail(Console.ReadLine());
            Console.WriteLine("Digite o telefone do funcionario: ");
            f.SetFone(Console.ReadLine());
            c.Inserir(f);
        }

        static void InserirEngenheiro(Construtora c)
        {
            Engenheiro e = new Engenheiro();
            Console.WriteLine("Digite o nome do funcionario: ");
            e.SetNome(Console.ReadLine());
            Console.WriteLine("Digite o e-mail do funcionario: ");
            e.SetEmail(Console.ReadLine());
            Console.WriteLine("Digite o telefone do funcionario: ");
            e.SetFone(Console.ReadLine());
            Console.WriteLine("Digite o registro do CREA do funcionario: ");
            e.SetCrea(Console.ReadLine());
            c.Inserir(e);
        }

        static void InserirMotorista(Construtora c)
        {
            Motorista m = new Motorista();
            Console.WriteLine("Digite o nome do funcionario: ");
            m.SetNome(Console.ReadLine());
            Console.WriteLine("Digite o e-mail do funcionario: ");
            m.SetEmail(Console.ReadLine());
            Console.WriteLine("Digite o telefone do funcionario: ");
            m.SetFone(Console.ReadLine());
            Console.WriteLine("Digite o numero do CNH do funcionario: ");
            m.SetCnh(Console.ReadLine());
            c.Inserir(m);
        }
    }
}
