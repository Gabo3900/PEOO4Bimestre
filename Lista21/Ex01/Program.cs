using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            Teste t = new Teste();
            t.Metodo1(int.Parse(Console.ReadLine()));
        }
    }
}
