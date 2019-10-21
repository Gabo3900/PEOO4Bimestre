using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Jogador : IComparable<Jogador>
    {
        private string nome;
        private string email;
        private int pontuacaoMaxima;
        private DateTime data;
        public Jogador(string n, string e)
        {
            nome = n;
            email = e;
        }
        public void SetPontos(int p, DateTime d)
        {
            if (p >= 0) pontuacaoMaxima = p;
            else throw new ArgumentOutOfRangeException();
            if (d <= DateTime.Now) data = d;
            else throw new ArgumentOutOfRangeException();
        }
        public override string ToString()
        {
            return $"{nome} {email} {pontuacaoMaxima} {data}";
        }
        public int CompareTo(Jogador j)
        {
            if (pontuacaoMaxima > j.pontuacaoMaxima) return 1;
            if (pontuacaoMaxima < j.pontuacaoMaxima) return -1;

            return data.CompareTo(j.data);
        }
    }
}
