using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DllControleDeVendas.Sistema.Negocio
{
    public class clnCategoria
    {
        // Cria todos os métodos internos e propriedades externas como os mesmos atributos do banco de dados
        // Atributos
        private int _cat_ID;
        private String _cat_Descricao;

        // Gets e Sets       
        public int Cat_ID
        {
            get { return _cat_ID; }
            set { _cat_ID = value; }
        }
        public string Cat_Descricao
        {
            get { return _cat_Descricao; }
            set { _cat_Descricao = value; }
        }

        // Método alterar
        public void Alterar(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "update Categoria set CAT_DESCRICAO = '"+ Cat_Descricao + "' where CAT_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método excluir
        public void Excluir(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "delete from Categoria where CAT_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método gravar
        public void Gravar()
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "insert into Categoria (CAT_DESCRICAO) values ('" + Cat_Descricao + "')";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método listar
        public DataSet Listar(String descricao)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select CAT_ID as Código, CAT_DESCRICAO as Descrição from Categoria where CAT_DESCRICAO like '%" + descricao + "%'";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataSet(sql);
        }

        // Método listarCategoria
        public SqlDataReader ListarCategoria(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select * from Categoria where CAT_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataReader(sql);
        }
    }
}
