using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;

namespace ControleDeVendas_Rodrigo_52718.Formularios.Cadastros.Produto
{
    public partial class frmProdutoConsulta : ControleDeVendas_Rodrigo_52718.Formularios.Modelos.frmModeloConsulta
    {
        public frmProdutoConsulta()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            clnProduto produto = new clnProduto();
            dgdGrid.DataSource = produto.Listar(txtDescricao.Text).Tables[0];
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmProdutoCadastro produtoCadastro = new frmProdutoCadastro();
            produtoCadastro.Operacao = clnFuncoesGerais.Operacao.Inclusao;
            produtoCadastro.ShowDialog();
            CarregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o produto?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                clnProduto produto = new clnProduto();
                produto.Excluir((int)(dgdGrid.CurrentRow.Cells[0].Value));
                MessageBox.Show("Produto excluído com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmProdutoCadastro produtoCadastro = new frmProdutoCadastro();
            produtoCadastro.Operacao = clnFuncoesGerais.Operacao.Alteracao;
            produtoCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            produtoCadastro.ShowDialog();
            CarregaGrid();
        }
    }
}
