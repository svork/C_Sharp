using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    class Avaliacao : Aluno
    {
        // Atributos
        private float nota1;
        private float nota2;
        private float nota3;

        // Construtor
        public Avaliacao(string nome, int matricula) : base(nome, matricula)
        {

        }

        // Gets e Sets
        public void setNotas(float n1, float n2, float n3)
        {
            this.nota1 = n1;
            this.nota2 = n2;
            this.nota3 = n3;
        }

        // Calcular Média
        // Este método, quando chamado, deverá executar uma média aritmética das 3 notas e retornar o valor calculado (do tipo float)
        public float CalcularMedia()
        {
            float media = 0;
            media = ( nota1 + nota2 + nota3 ) / 3;
            return media;
        }

        /* Verificar Aprovacao
           Este método, quando chamado, deverá retornar um valor booleano, sendo true = aprovado e false = reprovado. 
           As condições para aprovação/reprovação do aluno são as seguintes
                - se média >= 7.0 (aprovado)
                - se média < 7.0 (reprovado)
        */
        public Boolean VerificarAprovacao(float media)
        {
            Boolean aprovado;

            if ( media >= 7)
            {
                aprovado = true;
            }
            else
            {
                aprovado = false;
            }

            return aprovado;
        }
    }
}
