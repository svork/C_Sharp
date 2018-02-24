using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_02
{
    class Pessoa
    {
        // Attributes
        private String nome;
        private int idade;
        private Double altura;

        // Builder
        public Pessoa(String nome, int idade, Double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
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
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public int getIdade()
        {
            return this.idade;
        }
        public void setAltura(Double altura)
        {
            this.altura = altura;
        }
        public Double getAltura()
        {
            return this.altura;
        }
    }
}
