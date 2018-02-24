using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class Vendedor : Funcionario
    {
        // Atributos
        double comissaoPorCent;
        double comissao;

        // Construtor - passa parametros ao construtor da classe base
        public Vendedor(double comissao, string nome, double salario) : base(nome, salario)
        {
            this.comissao = comissao;
        }

        // Metodo Vender
        public void vender(double valor_venda)
        {
            setComissao(getComissao() + valor_venda);
        }
        
        // Gets and Sets
        public void setComissaoPorCent(double valor)
        {
            this.comissaoPorCent = valor;
        }
        public double getComissaoPorCent()
        {
            return this.comissaoPorCent;
        }
        public void setComissao(double valor)
        {
            this.comissao = valor;
        }
        public double getComissao()
        {
            return this.comissao;
        }

    }
}
