using System;
using System.Collections.Generic;

namespace Ex05
{
    class Aluno : IComparable<Aluno>
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public int CompareTo(Aluno a)
        {
            return Nome.CompareTo(a.Nome);
        }
    }

    class Turma : IComparable<Turma>
    {
        private string semestre;
        private string discplina;
        private List<Aluno> alunos;
        public Turma(string s, string d)
        {
            semestre = s;
            discplina = d;
            alunos = new List<Aluno>();
        }
        public int numAluno
        {
            get { return alunos.Count; }
        }
        public void AdicionarAluno(Aluno a)
        {
            alunos.Add(a);
        }
        public Aluno[] ListarAluno()
        {
            Aluno[] a = alunos.ToArray();
            Array.Sort(a);
            return a;
        }
        public int CompareTo(Turma t)
        {
            int s = semestre.CompareTo(t.semestre);
            if (s == 0) return discplina.CompareTo(t.discplina);
            return s;
        }
    }

    class Curso
    {
        private string descricao;
        private List<Turma> turmas;
        public Curso(string d)
        {
            descricao = d;
            turmas = new List<Turma>();
        }
        public void AdicionarTurma(Turma t)
        {
            turmas.Add(t);
        }
        public Turma[] ListarTurma()
        {
            Turma[] t = turmas.ToArray();
            Array.Sort(t);
            return t;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
