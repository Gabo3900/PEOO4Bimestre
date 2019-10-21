using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Jogo
    {
        private string nome;
        private List<Jogador> jogs;
        public Jogo(string n)
        {
            nome = n;
        }
        public void Inserir(Jogador j)
        {
            string email = j.ToString().Split()[1];
            foreach (Jogador n in Listar())
            {
                if (email == n.ToString().Split()[1]) throw new EmailExistenteException();
            }
            jogs.Add(j);
            jogs.Sort();
        }
        public List<Jogador> Listar()
        {
            return jogs;
        }
        public Jogador Top1()
        {
            return jogs[0];
        }
        public List<Jogador> Top10()
        {
            return jogs.GetRange(0, 10);
        }
        public override string ToString()
        {
            return $"{nome} {jogs.Count}";
        }
    }
}
