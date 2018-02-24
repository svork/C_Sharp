using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class frm_desafio : Form
    {
        public frm_desafio()
        {
            InitializeComponent();
        }

        // Lista para receber os valores que o usuário digitar
        List<string> lista = new List<String>();

        // Variável para controlar o tamanho da lista
        int tamanho_lista = 0;
        
        private void addVetor(String item)
        {
            // Esse método adiciona o que o usuário digitou em uma lista
            lista.Add(item);
            tamanho_lista++;
        }

        private void preencherVetor(List<string> lista){
            // Esse método recebe uma lista de strings e adiciona a uma lista
            for (int i = 0; i < tamanho_lista; i++)
            {
                list_input.Items.Add(lista[i]); // Adiciona item do vetor para a lista
            }
            
        }

        private void separarItens(List<string> lista)
        {
            Double numero = 0;
            // Esse método separa os itens do vetor e os adiciona a cada lista, Strings ou Decimais
            for (int i = 0; i < tamanho_lista; i++)
            {
                if (Double.TryParse(lista[i],out numero))
                {
                    list_decimal.Items.Add(lista[i]);
                }
                else
                {
                    list_strings.Items.Add(lista[i]);
                }
            }
        }

        private void btn_add_array_Click(object sender, EventArgs e)
        {
            addVetor(txt_Input.Text);
        
            // Limpa o campo de texto
            txt_Input.Clear();
        }

        private void btn_fill_list_Click(object sender, EventArgs e)
        {
            preencherVetor(lista);
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            separarItens(lista);
        }
    }
}
