using System;
using System.Collections.Generic;

namespace Ex01
{
    class Conversor
    {
        private int num;
        private Stack<int> pilha = new Stack<int>();
        public void SetNum(int num)
        {
            this.num = num;
        }
        public string Binario()
        {
            int aux;
            int n = num;
            while (n > 0)
            {
                aux = n % 2;
                pilha.Push(aux);
                n = n / 2;
            }
            string binario = "";
            while (pilha.Count > 0) binario += pilha.Pop();
            return binario;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            Conversor c = new Conversor();
            c.SetNum(int.Parse(Console.ReadLine()));
            Console.WriteLine(c.Binario());
        }
    }
}
