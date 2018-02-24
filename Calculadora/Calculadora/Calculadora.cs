using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        // Atributos
        double[] elementos; // Vetor para receber os elementos da contas matemáticas

        // Construtor
        public Calculadora()
        {

        }

        // Gets and Sets
        public void setElementos(double[] elementos)
        {
            this.elementos = elementos;
        }
        public double[] getElementos()
        {
            return this.elementos;
        }

        // Métodos Operações Matemáticas
        // Adição
        public double soma(double[] elementos)
        {
            double resultado = 0;

            for (int i = 0; i < elementos.Length; i++)
            {
                resultado += elementos[i];
            }

            return resultado;
        }

        // Subtração
        public double subtracao(double[] elementos)
        {
            double resultado = 0;

            for (int i = 0; i < elementos.Length; i++)
            {
                resultado -= elementos[i];
            }

            return resultado;
        }

        // Multiplicação
        public double multiplicacao(double[] elementos)
        {
            double resultado = 0;

            for (int i = 0; i < elementos.Length; i++)
            {
                resultado *= elementos[i];
            }

            return resultado;
        }

        // Divisão
        public double divisao(double[] elementos)
        {
            double resultado = 1;

            for (int i = 0; i < elementos.Length; i++)
            {
                resultado /= elementos[i];
            }

            return resultado;
        }
    }
}
