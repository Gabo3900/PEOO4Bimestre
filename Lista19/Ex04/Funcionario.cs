using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04
{
    class Funcionario
    {
        private string nome;
        private string email;
        private string fone;
        public void SetNome(string n) { nome = n; }
        public void SetEmail(string e) { email = e; }
        public void SetFone(string f) { fone = f; }
        public string GetNome() { return nome; }
        public string GetEmail() { return email; }
        public string GetFone() { return fone; }
        public override string ToString() { return $"{nome} {email} {fone}"; }
    }
}
