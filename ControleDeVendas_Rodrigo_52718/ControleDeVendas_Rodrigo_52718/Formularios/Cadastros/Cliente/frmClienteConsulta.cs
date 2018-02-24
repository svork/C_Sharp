using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;

namespace ControleDeVendas_Rodrigo_52718.Formularios.Cadastros.Cliente
{
    public partial class frmClienteConsulta : ControleDeVendas_Rodrigo_52718.Formularios.Modelos.frmModeloConsulta
    {
        public frmClienteConsulta()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            clnCliente cliente = new clnCliente();
            dgdGrid.DataSource = cliente.Listar(txtDescricao.Text).Tables[0];
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmClienteCadastro clienteCadastro = new frmClienteCadastro();
            clienteCadastro.Operacao = clnFuncoesGerais.Operacao.Inclusao;
            clienteCadastro.ShowDialog();
            CarregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir o cliente?", this.Text, MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                clnCliente cliente = new clnCliente();
                cliente.Excluir((int)(dgdGrid.CurrentRow.Cells[0].Value));
                MessageBox.Show("Cliente excluído com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmClienteCadastro clienteCadastro = new frmClienteCadastro();
            clienteCadastro.Operacao = clnFuncoesGerais.Operacao.Alteracao;
            clienteCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            clienteCadastro.ShowDialog();
            CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
