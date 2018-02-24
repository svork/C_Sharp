using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class Form1 : Form
    {
        // Instaciando vetor da classe Funcionario
        Funcionario[] vetorFuncionario = new Funcionario[3];

        public Form1()
        {
            InitializeComponent();

            // Abre o form no meio da tela
            StartPosition = FormStartPosition.CenterScreen;

            // Atribuindo Valores aos objetos
            vetorFuncionario[0] = new Funcionario("Vanessa", 1000.00);
            vetorFuncionario[1] = new Funcionario("Patricia", 2000.00);
            vetorFuncionario[2] = new Funcionario("Camila", 1500.00);

        }
        // Método para exibir Funcionários em uma Message Box
        public void mostrarFuncionarios(){

            MessageBox.Show("Funcionário : " + vetorFuncionario[0].getNome() + "\nSalário: " + vetorFuncionario[0].getSalario() + "\n" +
            "\nFuncionário : " + vetorFuncionario[1].getNome() + "\nSalário: " + vetorFuncionario[1].getSalario() + "\n" +
            "\nFuncionário : " + vetorFuncionario[2].getNome() + "\nSalário: " + vetorFuncionario[2].getSalario() 
            ,"Funcionário e Salários",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        // Método para exibir Funcionários com o novo salário em uma Message Box
        public void mostrarFuncionariosNovoSalarios()
        {
            // Aumentando o salário em 10%
            double salario0 = vetorFuncionario[0].getSalario() + (vetorFuncionario[0].getSalario() * 0.1);
            double salario1 = vetorFuncionario[1].getSalario() + (vetorFuncionario[1].getSalario() * 0.1);
            double salario2 = vetorFuncionario[2].getSalario() + (vetorFuncionario[2].getSalario() * 0.1);

            MessageBox.Show("\tAcréscimo de %10 no Salário\n\nFuncionário : " + vetorFuncionario[0].getNome() + "\nSalário: " + salario0 + "\n" +
            "\nFuncionário : " + vetorFuncionario[1].getNome() + "\nSalário: " + salario1 + "\n" +
            "\nFuncionário : " + vetorFuncionario[2].getNome() + "\nSalário: " + salario2
            ,"Funcionário e Salários", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarFuncionarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarFuncionariosNovoSalarios();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Botão Sair pergunta se o usuário tem certeza se quer sair do programa
            if (MessageBox.Show("Deseja realmente sair?", "Sair do Programa", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            // Botão para chamar o form Vendedor
            frmVendedor vendedor = new frmVendedor();
            vendedor.Show();
        }
    }
}

