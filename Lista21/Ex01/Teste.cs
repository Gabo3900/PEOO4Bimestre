using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01
{
    class Teste : ITeste
    {
        public int Metodo1(int valor)
        {
            if (valor < 0) throw new Erro();
            return valor;
        }
    }
}
