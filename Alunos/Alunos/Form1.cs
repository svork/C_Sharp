using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alunos
{
    public partial class frmAlunos : Form
    {
        // Instanciando a classe Avaliacao
        Avaliacao a1 = new Avaliacao("Vanessa Soares", 3546);

        public frmAlunos()
        {
            InitializeComponent();

            // Abre o form no meio da tela
            StartPosition = FormStartPosition.CenterScreen;

            // Mostrar nome e matricula
            txtNome.Text = a1.getNome();
            txtMatricula.Text = "" + a1.getMatricula();
        }

        // Método Média
        public void media()
        {
            try
            {
                float n1, n2, n3 = 0;

                // Tenta converter o input do usuário em Float
                n1 = float.Parse(txtN1.Text);
                n2 = float.Parse(txtN2.Text);
                n3 = float.Parse(txtN3.Text);

                // Passa as notas ao objeto
                a1.setNotas(n1, n2, n3);

                // Calcula a média e define o status do aluno
                if (a1.VerificarAprovacao(a1.CalcularMedia()))
                {
                    // Aprovado, mostra a nota e o status como aprovado em Verde
                    lblStatus.Text = "APROVADO";
                    lblStatus.BackColor = Color.LightGreen;
                    lblMedia.Text = "" + a1.CalcularMedia();
                    lblMedia.BackColor = Color.LightGreen;
                }
                else
                {
                    // Reprovado, mostra a nota e o status como reprovado em Vermelho
                    lblStatus.Text = "REPROVADO";
                    lblStatus.BackColor = Color.Red;
                    lblMedia.Text = "" + a1.CalcularMedia();
                    lblMedia.BackColor = Color.Red;
                }
            }
            catch (Exception)
            {
                // Mostra mensagem ao usuário dizendo que os valores estão errados
                MessageBox.Show("Erro ao digitar notas!\nDigite apenas números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpa os campos de notas
                txtN1.Clear();
                txtN2.Clear();
                txtN3.Clear();

                // Volta para o campo N1
                txtN1.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Botão Sair pergunta se o usuário tem certeza se quer sair do programa
            if (MessageBox.Show("Deseja realmente sair?", "Sair do Programa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            // Método média
            media();
        }
    }
}
