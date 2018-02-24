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


namespace ControleDeVendas_Rodrigo_52718.Formularios.Cadastros.Cliente
{
    public partial class frmClienteCadastro : ControleDeVendas_Rodrigo_52718.Formularios.Modelos.frmModeloCadastro
    {
        public frmClienteCadastro()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(string.Empty))
            {
                errError.SetError(txtNome, "Digite um nome");
                return;
            }
            else
            {
                errError.SetError(txtNome, "");
            }

            if (txtCpfCnpj.Text.Equals(string.Empty))
            {
                errError.SetError(txtCpfCnpj, "Digite um CPF/CNPJ");
                return;
            }
            else
            {
                errError.SetError(txtCpfCnpj, "");
            }
            if (txtLogradouro.Text.Equals(string.Empty))
            {
                errError.SetError(txtLogradouro, "Digite um logradouro");
                return;
            }
            else
            {
                errError.SetError(txtLogradouro, "");
            }
            if (txtBairro.Text.Equals(string.Empty))
            {
                errError.SetError(txtBairro, "Digite um bairro");
                return;
            }
            else
            {
                errError.SetError(txtBairro, "");
            }
            if (txtCidade.Text.Equals(string.Empty))
            {
                errError.SetError(txtCidade, "Digite uma cidade");
                return;
            }
            else
            {
                errError.SetError(txtCidade, "");
            }
            if (cboUf.Text.Equals(string.Empty))
            {
                errError.SetError(cboUf, "Selecione uma UF");
                return;
            }
            else
            {
                errError.SetError(cboUf, "");
            }
            if (txtCep.Text.Equals(string.Empty))
            {
                errError.SetError(txtCep, "Digite um CEP");
                return;
            }
            else
            {
                errError.SetError(txtCep, "");
            }
            if (txtEmail.Text.Equals(string.Empty))
            {
                errError.SetError(txtEmail, "Digite um email");
                return;
            }
            else
            {
                errError.SetError(txtEmail, "");
            }
            if (txtTelefones.Text.Equals(string.Empty))
            {
                errError.SetError(txtTelefones, "Digite um telefone");
                return;
            }
            else
            {
                errError.SetError(txtTelefones, "");
            }
            clnCliente cliente = new clnCliente();
            cliente.Cli_bairro = txtBairro.Text;
            cliente.Cli_cep = txtCep.Text;
            cliente.Cli_cidade = txtCidade.Text;
            cliente.Cli_cnpjcpf = txtCpfCnpj.Text;         
            cliente.Cli_dtcadastro = DateTime.Now.ToString("yyyy-MM-dd"); // Pegando a data de Hoje
            cliente.Cli_email = txtEmail.Text;
            cliente.Cli_fones = txtTelefones.Text;
            cliente.Cli_logradouro = txtLogradouro.Text;
            cliente.Cli_nomerazao = txtNome.Text;
            cliente.Cli_uf = cboUf.Text;
            if(Operacao == clnFuncoesGerais.Operacao.Inclusao)
            {
                cliente.Gravar();
            }
            else if (Operacao == clnFuncoesGerais.Operacao.Alteracao)
            {                
                cliente.Alterar(Codigo);
            }
            MessageBox.Show("Cliente cadastrado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmClienteCadastro_Load(object sender, EventArgs e)
        {
            if(Operacao == clnFuncoesGerais.Operacao.Alteracao)
            {
                clnCliente cliente = new clnCliente();
                SqlDataReader drDados = null;
                drDados = cliente.ListarCliente(Codigo);                
                if (drDados.HasRows)
                {
                    while (drDados.Read())
                    {
                        txtNome.Text = drDados["cli_nomerazao"].ToString();
                        txtCpfCnpj.Text = drDados["cli_cnpjcpf"].ToString();
                        txtLogradouro.Text = drDados["cli_logradouro"].ToString();
                        txtBairro.Text = drDados["cli_bairro"].ToString();
                        txtCidade.Text = drDados["cli_cidade"].ToString();
                        cboUf.Text = drDados["cli_uf"].ToString();
                        txtCep.Text = drDados["cli_cep"].ToString();
                        txtEmail.Text = drDados["cli_email"].ToString();
                        txtTelefones.Text = drDados["cli_fones"].ToString();
                    }
                }                
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
