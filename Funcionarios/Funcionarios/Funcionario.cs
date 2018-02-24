using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Funcionario
    {
        // Atributos
        private String nome;
        private double salario;

        // Construtor
        public Funcionario(String nome, double salario)
        {
           this.nome = nome;
           this.salario = salario;
        }

        // Gets and Sets
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return this.nome;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return this.salario;
        }
    }
}
