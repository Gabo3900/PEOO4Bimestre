using System;
using System.Collections.Generic;

namespace Ex02
{
    class Pilha1<T>
    {
        private List<T> lista = new List<T>();
        private int k;
        public int Count()
        {
            return k;
        }
        public T Top()
        {
            return lista[k - 1];
        }
        public T Pop()
        {
            T obj = Top();
            lista.RemoveAt(k - 1);
            k--;
            return obj;
        }
        public void Push(T obj)
        {
            lista.Add(obj);
            k++;
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
