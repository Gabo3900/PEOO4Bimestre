using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string Genero { get; set; }
        public int IdAutor { get; set; }
    }
}
