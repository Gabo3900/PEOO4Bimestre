using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PGame
    {
        private string arquivo = "Games.xml";
        public List<Game> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Game>));
            StreamReader f = null;
            List<Game> cs = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = x.Deserialize(f) as List<Game>;
            }
            catch
            {
                cs = new List<Game>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Save(List<Game> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Game>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
