using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DllControleDeVendas.Sistema.Negocio
{
    public class clnItem
    {
        // Cria todos os métodos internos e propriedades externas como os mesmos atributos do banco de dados
        // Atributos
        private int _ite_id;
        private int _ped_id;
        private int _pro_id;
        private int _ite_qtde;
        private float _ite_valor;

        // Gets e Sets
        public int Ite_id
        {
            get { return _ite_id; }
            set { _ite_id = value; }
        }
        public int Ped_id
        {
            get { return _ped_id; }
            set { _ped_id = value; }
        }
        public int Pro_id
        {
            get { return _pro_id; }
            set { _pro_id = value; }
        }
        public int Ite_qtde
        {
            get { return _ite_qtde; }
            set { _ite_qtde = value; }
        }
        public float Ite_valor
        {
            get { return _ite_valor; }
            set { _ite_valor = value; }
        }

        // Método alterar
        public void Alterar(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "update Item set " +
                         "PED_ID = " + Ped_id + ", " +
                         "PRO_ID = " + Pro_id + ", " +
                         "ITE_QTDE = " + Ite_qtde + ", " +
                         "ITE_VALOR = " + Ite_valor + " " +                         
                         "where ITE_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método excluir
        public void Excluir(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "delete from Item where ITE_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método gravar
        public void Gravar()
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "insert into Item (PED_ID, PRO_ID, ITE_QTDE, ITE_VALOR) values ( " +
                         Ped_id + ", " +
                         Pro_id + ", " +
                         Ite_qtde + ", " +
                         Ite_valor + " " +
                         ")";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método listar
        public DataSet Listar(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select Item.ITE_ID as Item, Produto.PRO_ID as 'Código do Produto', Produto.PRO_DESCRICAO as Descricao, Item.ITE_VALOR as 'Valor Unitário', Item.ITE_QTDE as Quantidade, Item.ITE_QTDE * Item.ITE_VALOR as Subtotal from Item join Produto on Produto.PRO_ID = Item.PRO_ID join Pedido on Pedido.PED_ID = Item.PED_ID where Pedido.PED_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataSet(sql);
        }
    }
}
