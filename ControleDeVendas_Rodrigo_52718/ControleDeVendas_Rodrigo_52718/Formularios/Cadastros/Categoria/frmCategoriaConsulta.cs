using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;

namespace ControleDeVendas_Rodrigo_52718.Formularios.Cadastros.Categoria
{
    public partial class frmCategoriaConsulta : ControleDeVendas_Rodrigo_52718.Formularios.Modelos.frmModeloConsulta
    {
        public frmCategoriaConsulta()
        {
            InitializeComponent();            
        }

        private void CarregaGrid()
        {
            clnCategoria categoria = new clnCategoria();
            dgdGrid.DataSource = categoria.Listar(txtDescricao.Text).Tables[0];
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCategoriaCadastro categoriaCadastro = new frmCategoriaCadastro();
            categoriaCadastro.Operacao = clnFuncoesGerais.Operacao.Inclusao;
            categoriaCadastro.ShowDialog();
            CarregaGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a categoria?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                clnCategoria categoria = new clnCategoria();
                categoria.Excluir((int)(dgdGrid.CurrentRow.Cells[0].Value));
                MessageBox.Show("Categoria excluído com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmCategoriaCadastro categoriaCadastro = new frmCategoriaCadastro();
            categoriaCadastro.Operacao = clnFuncoesGerais.Operacao.Alteracao;
            categoriaCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            categoriaCadastro.ShowDialog();
            CarregaGrid();
        }

    }
}
