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

namespace ControleDeVendas_Rodrigo_52718.Formularios.Cadastros.Produto
{
    public partial class frmProdutoCadastro : ControleDeVendas_Rodrigo_52718.Formularios.Modelos.frmModeloCadastro
    {
        public frmProdutoCadastro()
        {
            InitializeComponent();
        }

        int ativo = 1;

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (cboCategoria.Text.Equals(string.Empty))
            {
                errError.SetError(cboCategoria, "Selecione uma categoria");
                return;
            }
            else
            {
                errError.SetError(cboCategoria, "");
            }

            if (txtDescricao.Text.Equals(string.Empty))
            {
                errError.SetError(txtDescricao, "Digite uma descrição");
                return;
            }
            else
            {
                errError.SetError(txtDescricao, "");
            }

            if (txtValor.Text.Equals(string.Empty))
            {
                errError.SetError(txtValor, "Digite um valor");
                return;
            }
            else
            {
                errError.SetError(txtValor, "");
            }

            clnProduto produto = new clnProduto();
            produto.Cat_id = int.Parse(cboCategoria.Text);
            produto.Pro_descricao = txtDescricao.Text;                       
            produto.Pro_qtdeestoque = (int)nudQuantidade.Value;

            // Corrigindo problema da virgula
            String valor = txtValor.Text;            
            produto.Pro_valor = float.Parse(valor.Replace(",", "."));     
            ativo = 1; // BIT 1 = ativo, 0 = não-ativo
            if (optNao.Checked)
            {
                ativo = 0;
            }
            produto.Pro_ativo = ativo;
            if (Operacao == clnFuncoesGerais.Operacao.Inclusao)
            {
                produto.Gravar();
            }
            else if (Operacao == clnFuncoesGerais.Operacao.Alteracao)
            {
                produto.Alterar(Codigo);
            }
            MessageBox.Show("Produto cadastrado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmProdutoCadastro_Load(object sender, EventArgs e)
        {
            if (Operacao == clnFuncoesGerais.Operacao.Alteracao)
            {
                clnProduto produto = new clnProduto();
                SqlDataReader drDados = null;
                drDados = produto.ListarProduto(Codigo);
                if (drDados.HasRows)
                {
                    while (drDados.Read())
                    {                        
                        cboCategoria.Text = drDados["cat_id"].ToString();
                        txtDescricao.Text = drDados["pro_descricao"].ToString();
                        txtValor.Text = drDados["pro_valor"].ToString();
                        nudQuantidade.Value = decimal.Parse(drDados["pro_qtdeestoque"].ToString());
                        ativo = int.Parse(drDados["pro_ativo"].ToString());                        
                    }
                }
            }
        }
    }
}
