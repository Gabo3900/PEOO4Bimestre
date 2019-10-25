using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negocio
{
    public class NGame
    {
        public List<Game> Select()
        {
            PGame p = new PGame();
            return p.Open().OrderBy(c => c.Nome).ToList();
        }
        public List<Game> SelectData()
        {
            PGame p = new PGame();
            return p.Open().OrderBy(c => c.DataCompra).ToList();
        }
        public List<Game> Top10()
        {
            PGame p = new PGame();
            return p.Open().OrderBy(c => c.Estrelas).ToList().GetRange(0, 10);
        }
        public void Insert(Game c)
        {
            PGame p = new PGame();
            List<Game> cs = p.Open();
            int m = 0;
            foreach (Game x in cs) if (x.Id > m) m = x.Id;
            c.Id = m + 1;
            cs.Add(c);
            p.Save(cs);
        }
        public void Update(Game c)
        {
            PGame p = new PGame();
            List<Game> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            cs.Add(c);
            p.Save(cs);
        }
        public void Delete(Game c)
        {
            PGame p = new PGame();
            List<Game> cs = p.Open();
            for (int i = 0; i < cs.Count; i++)
                if (cs[i].Id == c.Id)
                {
                    cs.RemoveAt(i);
                    break;
                }
            p.Save(cs);
        }
    }
}
