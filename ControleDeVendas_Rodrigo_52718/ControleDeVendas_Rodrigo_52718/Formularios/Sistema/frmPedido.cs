using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;
using System.Data.SqlClient;

namespace ControleDeVendas_Rodrigo_52718.Formularios.Sistema
{
    public partial class frmPedido : ControleDeVendas_Rodrigo_52718.Formularios.Modelos.frmModeloCadastro
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        // Código do Produto para o método AdicionarItem
        int PRO_ID = 0;

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            clnPedido pedido = new clnPedido();
            if (Operacao == clnFuncoesGerais.Operacao.Inclusao)
            {                
                pedido.Gravar();
            }
            else if (Operacao == clnFuncoesGerais.Operacao.Alteracao)
            {
                pedido.Alterar(Codigo);
            }
            MessageBox.Show("Pedido cadastrado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            if (Operacao == clnFuncoesGerais.Operacao.Alteracao)
            {
                txtCliente.Enabled = false;
                btnCliente.Enabled = false;

                clnPedido pedido = new clnPedido();
                SqlDataReader drDados = null;
                drDados = pedido.ListarPedido(Codigo);
                if (drDados.HasRows)
                {
                    while (drDados.Read())
                    {
                        txtCliente.Text = drDados["CLI_NOMERAZAO"].ToString();
                        dtpData.Text = drDados["PED_DTENCOMENDA"].ToString();
                    }
                }
                clnItem item = new clnItem();
                dtgItem.DataSource = item.Listar(Codigo).Tables[0];
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            clnCliente cliente = new clnCliente();
            SqlDataReader drDados = null;
            drDados = cliente.ListarCliente(txtCliente.Text);
            if (drDados.HasRows)
            {
                while (drDados.Read())
                {
                    txtCliente.Text = drDados["cli_nomerazao"].ToString();
                }
            }
            dtpData.Text = DateTime.Now.ToLongDateString();
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            clnProduto produto = new clnProduto();
            SqlDataReader drDados = null;
            drDados = produto.ListarProduto(txtProduto.Text);
            if (drDados.HasRows)
            {
                while (drDados.Read())
                {                    
                    txtProduto.Text = drDados["pro_descricao"].ToString();
                    txtValor.Text = drDados["pro_valor"].ToString();
                    txtQuantidade.Text = drDados["pro_qtdeestoque"].ToString();
                    PRO_ID = int.Parse(drDados["pro_id"].ToString());
                }
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o item selecionado?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                clnItem item = new clnItem();
                item.Excluir((int)(dtgItem.CurrentRow.Cells[0].Value));
                MessageBox.Show("Item excluído com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgItem.DataSource = item.Listar(Codigo).Tables[0];                
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            clnItem item = new clnItem();
            item.Ped_id = Codigo;
            item.Pro_id = PRO_ID;
            item.Ite_qtde = int.Parse(txtQuantidade.Text);
            item.Ite_valor = float.Parse(txtValor.Text.Replace(",","."));
            item.Gravar();
            dtgItem.DataSource = item.Listar(Codigo).Tables[0];
        }
    }
}
