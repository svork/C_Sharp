using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    class Aluno
    {
        // Atributos
        private string nome;
        private int matricula;

        // Construtor
        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        // Gets and Sets
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public int getMatricula()
        {
            return this.matricula;
        }
    }
}
