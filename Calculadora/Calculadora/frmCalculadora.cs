using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        // Instanciando classe Calculadora
        Calculadora calc = new Calculadora();

        // Vetor para receber os elementos das operações
        double[] numeros = new Double[100];

        // índice do vetor
        int i = 0;

        public frmCalculadora()
        {
            InitializeComponent();

            // Abre o form no meio da tela
            StartPosition = FormStartPosition.CenterScreen;
        }

        // Adiciona número digitado ao vetor de números
        public void add(double n)
        {
            txtNumeros.AppendText(" " + n + " ");
            numeros[i] = n;
            i++;
            lblN.Text = ("" + i + "");
        }

        // Limpa a tela e zera o vetor de números
        public void limpar()
        {
            i = 0;
            for (int j = 0; j < numeros.Length; j++)
            {
                numeros[j] = 0; // Zera o Vetor
            }
            txtNumeros.Clear();
            lblN.Text = ("" + i + "");
            lblResultado.Text = "0";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Botão Sair pergunta se o usuário tem certeza se quer sair do programa
            if (MessageBox.Show("Deseja realmente sair?", "Sair do Programa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Botões de Numeros da Calculadora
        private void button1_Click(object sender, EventArgs e)
        {
            add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            add(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            add(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            add(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            add(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            add(0);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa a tela da calculadora e zera o vetor
            limpar();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            // Soma
            lblResultado.Text = " " + calc.soma(numeros);
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            // Subtracao
            lblResultado.Text = " " + calc.subtracao(numeros);
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            // Multiplicacao
            lblResultado.Text = " " + calc.multiplicacao(numeros);
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            // Divisão
            lblResultado.Text = " " + calc.divisao(numeros);
        }
    }
}
