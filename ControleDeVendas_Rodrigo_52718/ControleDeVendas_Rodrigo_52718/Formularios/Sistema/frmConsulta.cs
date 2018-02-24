using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;

namespace ControleDeVendas_Rodrigo_52718.Formularios.Sistema
{
    public partial class frmConsulta : ControleDeVendas_Rodrigo_52718.Formularios.Modelos.frmModeloConsulta
    {
        public frmConsulta()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            clnPedido pedido = new clnPedido();
            if (txtDescricao.Text.Equals(string.Empty))
            {
                errError.SetError(txtDescricao, "Digite um código");
                return;
            }
            else
            {
                errError.SetError(txtDescricao, "");
            }
            dgdGrid.DataSource = pedido.Listar(int.Parse(txtDescricao.Text)).Tables[0];
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o pedido?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                clnPedido pedido = new clnPedido();
                pedido.Excluir((int)(dgdGrid.CurrentRow.Cells[0].Value));
                MessageBox.Show("Pedido excluído com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            pedido.Operacao = clnFuncoesGerais.Operacao.Inclusao;
            pedido.ShowDialog();
            CarregaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            pedido.Operacao = clnFuncoesGerais.Operacao.Alteracao;
            pedido.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            pedido.ShowDialog();
            CarregaGrid();            
        }
    }
}
