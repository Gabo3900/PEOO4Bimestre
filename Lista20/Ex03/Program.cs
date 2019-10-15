using System;
using System.Collections.Generic;

namespace Ex03
{
    class Pilha2<T>
    {
        private Queue<T> q1 = new Queue<T>();
        private Queue<T> q2 = new Queue<T>();
        public int Count()
        {
            while (q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }
            return q1.Count;
        }
        public T Top()
        {
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }
            return q2.Peek();
        }
        public T Pop()
        {
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }
            return q2.Dequeue();
        }
        public void Push(T obj)
        {
            while (q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }
            q1.Enqueue(obj);
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
