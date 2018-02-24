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

namespace ControleDeVendas_Rodrigo_52718.Formularios.Cadastros.Categoria
{
    public partial class frmCategoriaCadastro : ControleDeVendas_Rodrigo_52718.Formularios.Modelos.frmModeloCadastro
    {
        public frmCategoriaCadastro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(string.Empty))
            {
                errError.SetError(txtNome, "Digite uma descrição");
                return;
            }
            else
            {
                errError.SetError(txtNome, "");
            }
            clnCategoria categoria = new clnCategoria();
            categoria.Cat_Descricao = txtNome.Text;

            if (Operacao == clnFuncoesGerais.Operacao.Inclusao)
            {
                categoria.Gravar();
            }
            else if(Operacao == clnFuncoesGerais.Operacao.Alteracao)
            {
                categoria.Alterar(Codigo);
            }
            MessageBox.Show("Categoria cadastrada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmCategoriaCadastro_Load(object sender, EventArgs e)
        {
            if (Operacao == clnFuncoesGerais.Operacao.Alteracao)
            {
                clnCategoria categoria = new clnCategoria();
                SqlDataReader drDados = null;
                drDados = categoria.ListarCategoria(Codigo);
                if (drDados.HasRows)
                {
                    while (drDados.Read())
                    {
                        txtNome.Text = drDados["cat_descricao"].ToString();                       
                    }
                }
            }
        }
    }
}
