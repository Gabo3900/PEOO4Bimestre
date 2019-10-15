using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04
{
    class Engenheiro : Funcionario
    {
        private string crea;
        public void SetCrea(string c) { crea = c; }
        public string GetCrea() { return crea; }
        public override string ToString() { return $"{base.ToString()} {crea}"; }
    }
}
