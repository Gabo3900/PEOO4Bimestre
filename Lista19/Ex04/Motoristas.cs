using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04
{
    class Motorista : Funcionario
    {
        private string cnh;
        public void SetCnh(string c) { cnh = c; }
        public string GetCnh() { return cnh; }
        public override string ToString() { return $"{base.ToString()} {cnh}"; }
    }
}
