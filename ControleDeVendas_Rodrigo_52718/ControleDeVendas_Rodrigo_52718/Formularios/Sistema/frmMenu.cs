using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ControleDeVendas_Rodrigo_52718.Formularios.Cadastros.Cliente;
using ControleDeVendas_Rodrigo_52718.Formularios.Cadastros.Categoria;
using ControleDeVendas_Rodrigo_52718.Formularios.Cadastros.Produto;

namespace ControleDeVendas_Rodrigo_52718.Formularios.Sistema
{
    public partial class frmMenu : ControleDeVendas_Rodrigo_52718.Formularios.Modelos.frmModelo
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteConsulta clienteConsulta = new frmClienteConsulta();
            clienteConsulta.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriaConsulta categoriaConsulta = new frmCategoriaConsulta();
            categoriaConsulta.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutoConsulta produtoConsulta = new frmProdutoConsulta();
            produtoConsulta.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.ShowDialog();
        }
    }
}
