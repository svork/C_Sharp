using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_02
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        // Faz todo o processamento
        public void processar()
        {
            try
            {

                // Instanciando classe Pessoa
                Pessoa jailson = new Pessoa("Jailson Mendez", 32, 1.89);

                // Lendo valores do text field
                jailson.setNome(txtNome.Text);
                jailson.setIdade(int.Parse(txtIdade.Text));
                jailson.setAltura(double.Parse(txtAltura.Text));

                // Recebendo valores do objeto
                String nome = jailson.getNome();
                int idade = jailson.getIdade();
                Double altura = jailson.getAltura();

                // Mensagem ao clicar no botao Processar
                String mensagem = ("Nome: " + nome.ToUpper() + "\nIdade: " + idade.ToString() + "\nAltura: " + altura.ToString());
                MessageBox.Show(mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar campos depois de exibir
                limpar();

            }
            catch (Exception error)
            {
                // Error message
                MessageBox.Show(error.Message + "\n\n Voce esqueceu de digitar alguma informação!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear text fields
        public void limpar()
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtAltura.Clear();
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Close Button

            // Titulo e Texto da mensagem
            String texto = ("Deseja realmente sair?");
            String titulo = ("Sair");

            // Messagebox pergunta ao usuario
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
                        
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            // Process Button
            processar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Clear text fields
            limpar();
        }
        
        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Usuário apertou Enter
            if (e.KeyChar == 13) 
            {
                processar();
            }
            
        }
    }
}
