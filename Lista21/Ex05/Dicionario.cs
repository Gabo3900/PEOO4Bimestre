using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Dicionario<K, V>
    {
        private List<K> chaves = new List<K>();
        private List<V> valores = new List<V>();
        public List<K> Chaves
        {
            get { return chaves; }
        }
        public int Count
        {
            get { return chaves.Count; }
        }
        public V this[K i]
        {
            get { return valores[chaves.IndexOf(i)]; }
            set { valores[chaves.IndexOf(i)] = value; }
        }
        public void Add(K chave, V valor)
        {
            if (chave == null) throw new ArgumentNullException();
            if (Contains(chave)) throw new InvalidOperationException();
            chaves.Add(chave);
            valores.Add(valor);
        }
        public void Clear()
        {
            chaves.Clear();
            valores.Clear();
        }
        public bool Contains(K chave)
        {
            return chaves.Contains(chave);
        }
        public bool Remove(K chave)
        {
            if (Contains(chave))
            {
                chaves.Remove(chave);
                return true;
            }
            return false;
        }
    }
}
