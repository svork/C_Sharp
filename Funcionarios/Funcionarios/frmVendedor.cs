using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class frmVendedor : Form
    {

        // Instanciando a classe Vendedor
        Vendedor v1 = new Vendedor(15.00, "Vanessa", 3000.00);

        public frmVendedor()
        {
            InitializeComponent();

            // Abre o form no meio da tela
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void lblVendedor_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Botão volta a tela inicial
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            // Botao vender adiciona o valor da venda e da comissao
            try
            {
                v1.vender(Double.Parse(txtValorVenda.Text));
                MessageBox.Show("Venda realizada com sucesso!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorVenda.Clear();
                txtValorVenda.Focus();
            }
            catch (Exception )
            {
                MessageBox.Show("Erro ao digitar valor de venda!\nDigite apenas números" , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorVenda.Clear();
                txtValorVenda.Focus();
            }
        }

        private void btnMostrarComissao_Click(object sender, EventArgs e)
        {
            // Botao exibe o valor total da comissao do vendedor
            MessageBox.Show("Valor da Comissão: R$ " + v1.getComissao(), "Comissão", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
