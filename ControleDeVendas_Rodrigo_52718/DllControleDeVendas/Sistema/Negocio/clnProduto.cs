using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DllControleDeVendas.Sistema.Negocio
{
    public class clnProduto
    {
        // Cria todos os métodos internos e propriedades externas como os mesmos atributos do banco de dados
        // Atributos
        private int _pro_id;
        private int _cat_id;
        private String _pro_descricao;
        private int _pro_qtdeestoque;
        private float _pro_valor;
        private int _pro_ativo;

        // Gets e Sets
        public int Pro_id
        {
            get { return _pro_id; }
            set { _pro_id = value; }
        }
        public int Cat_id
        {
            get { return _cat_id; }
            set { _cat_id = value; }
        }
        public string Pro_descricao
        {
            get { return _pro_descricao; }
            set { _pro_descricao = value; }
        }
        public int Pro_qtdeestoque
        {
            get { return _pro_qtdeestoque; }
            set { _pro_qtdeestoque = value; }
        }
        public float Pro_valor
        {
            get { return _pro_valor; }
            set { _pro_valor = value; }
        }
        public int Pro_ativo
        {
            get { return _pro_ativo; }
            set { _pro_ativo = value; }
        }

        // Método alterar
        public void Alterar(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "update Produto set " +
                         "CAT_ID = " + Cat_id + ", " +
                         "PRO_DESCRICAO = '" + Pro_descricao + "', " +
                         "PRO_QTDEESTOQUE = " + Pro_qtdeestoque + ", " +
                         "PRO_VALOR = " + Pro_valor + ", " +
                         "PRO_ATIVO  = " + Pro_ativo + " " +
                         "where PRO_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método excluir
        public void Excluir(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "delete from Produto where PRO_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método gravar
        public void Gravar()
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "insert into Produto (CAT_ID, PRO_DESCRICAO, PRO_QTDEESTOQUE, PRO_VALOR, PRO_ATIVO) values ( " +
                         Cat_id + ", " +
                         "'" + Pro_descricao + "', " +
                         Pro_qtdeestoque + ", " +
                         Pro_valor + ", " +
                         Pro_ativo + ", " +
                         ")";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método listar
        public DataSet Listar(string descricao)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select PRO_ID as Código, Categoria.CAT_DESCRICAO as Categoria, PRO_DESCRICAO as Descrição, PRO_QTDEESTOQUE as Quantidade, PRO_VALOR as Valor, PRO_ATIVO as Ativo from Produto join Categoria on Produto.CAT_ID = Categoria.CAT_ID where PRO_DESCRICAO like '%" + descricao + "%'";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataSet(sql);
        }

        // Método listarCliente
        public SqlDataReader ListarProduto(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select * from Produto where PRO_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataReader(sql);
        }

        public SqlDataReader ListarProduto(String nome)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select * from Produto where PRO_DESCRICAO like '%" + nome + "%'";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataReader(sql);
        }
    }
}
