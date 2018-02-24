using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DllControleDeVendas.Sistema.Negocio
{
    public class clnCliente
    {
        // Cria todos os métodos internos e propriedades externas como os mesmos atributos do banco de dados
        // Atributos
        private int _cli_id;
        private String _cli_nomerazao;
        private String _cli_cnpjcpf;
        private String _cli_logradouro;
        private String _cli_bairro;
        private String _cli_cidade;
        private String _cli_uf;
        private String _cli_cep;
        private String _cli_email;
        private String _cli_fones;
        private String _cli_dtcadastro;

        // Gets e Sets
        public int Cli_id
        {
            get { return _cli_id; }
            set { _cli_id = value; }
        }
        public string Cli_nomerazao
        {
            get { return _cli_nomerazao; }
            set { _cli_nomerazao = value; }
        }
        public string Cli_cnpjcpf
        {
            get { return _cli_cnpjcpf; }
            set { _cli_cnpjcpf = value; }
        }
        public string Cli_logradouro
        {
            get { return _cli_logradouro; }
            set { _cli_logradouro = value; }
        }
        public string Cli_bairro
        {
            get { return _cli_bairro; }
            set { _cli_bairro = value; }
        }
        public string Cli_cidade
        {
            get { return _cli_cidade; }
            set { _cli_cidade = value; }
        }
        public string Cli_uf
        {
            get { return _cli_uf; }
            set { _cli_uf = value; }
        }
        public string Cli_cep
        {
            get { return _cli_cep; }
            set { _cli_cep = value; }
        }
        public string Cli_email
        {
            get { return _cli_email; }
            set { _cli_email = value; }
        }
        public string Cli_fones
        {
            get { return _cli_fones; }
            set { _cli_fones = value; }
        }
        public string Cli_dtcadastro
        {
            get { return _cli_dtcadastro; }
            set { _cli_dtcadastro = value; }
        }

        // Método alterar
        public void Alterar(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "update Cliente set " +
                         "CLI_NOMERAZAO = '" + Cli_nomerazao + "', " +
                         "CLI_CNPJCPF = '" + Cli_cnpjcpf + "', " +
                         "CLI_LOGRADOURO = '" + Cli_logradouro + "', " +
                         "CLI_BAIRRO = '" + Cli_bairro + "', " +
                         "CLI_CIDADE = '" + Cli_cidade + "', " +
                         "CLI_UF = '" + Cli_uf + "', " +
                         "CLI_CEP = '" + Cli_cep + "', " +
                         "CLI_EMAIL = '" + Cli_email + "', " +
                         "CLI_FONES = '" + Cli_fones + "', " +
                         "CLI_DTCADASTRO = '" + Cli_dtcadastro + "' " +
                         "where CLI_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método excluir
        public void Excluir(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "delete from Cliente where CLI_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método gravar
        public void Gravar()
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "insert into Cliente (CLI_NOMERAZAO, CLI_CNPJCPF, CLI_LOGRADOURO, CLI_BAIRRO, CLI_CIDADE, CLI_UF, CLI_CEP, CLI_EMAIL, CLI_FONES, CLI_DTCADASTRO) values ( " +
                         "'" + Cli_nomerazao + "', " +
                         "'" + Cli_cnpjcpf + "', " +
                         "'" + Cli_logradouro + "', " +
                         "'" + Cli_bairro + "', " +
                         "'" + Cli_cidade + "', " +
                         "'" + Cli_uf + "', " +
                         "'" + Cli_cep + "', " +
                         "'" + Cli_email + "', " +
                         "'" + Cli_fones + "', " +
                          "'" + Cli_dtcadastro + "'" +
                         ")";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método listar
        public DataSet Listar(String nome)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select CLI_ID as Código, CLI_NOMERAZAO as Nome, CLI_CNPJCPF as 'CNPJ / CPF', CLI_LOGRADOURO as Endereço, CLI_BAIRRO as Bairro, CLI_CIDADE as Cidade, CLI_UF as Estado, CLI_CEP as CEP, CLI_EMAIL as Email, CLI_DTCADASTRO as Data from Cliente where CLI_NOMERAZAO like '%" + nome + "%'";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataSet(sql);
        }

        // Método listarCliente
        public SqlDataReader ListarCliente(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select * from Cliente where CLI_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataReader(sql);
        }

        // Método listarCliente
        public SqlDataReader ListarCliente(String nome)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select CLI_NOMERAZAO from Cliente where CLI_NOMERAZAO like '%" + nome + "%'";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataReader(sql);
        }
    }
}
