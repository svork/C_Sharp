using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DllControleDeVendas.Sistema.Globais;

namespace ControleDeVendas_Rodrigo_52718.Formularios.Modelos
{
    public partial class frmModeloCadastro : ControleDeVendas_Rodrigo_52718.Formularios.Modelos.frmModelo
    {
        public frmModeloCadastro()
        {
            InitializeComponent();
        }

        // Atributos
        private clnFuncoesGerais.Operacao _Operacao;
        private int _codigo;        

        // Gets e Sets
        public clnFuncoesGerais.Operacao Operacao
        {
            get { return _Operacao; }
            set { _Operacao = value; }
        }
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
    }
}
