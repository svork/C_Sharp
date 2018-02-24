using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DllControleDeVendas.Sistema.Negocio
{
    public class clnPedido
    {
        // Cria todos os métodos internos e propriedades externas como os mesmos atributos do banco de dados
        // Atributos
        private int _ped_id;
        private int _cli_id;
        private String _ped_dtencomenda;
        private float _ped_valor;
        private String _ped_status;

        // Gets e Sets
        public int Ped_id
        {
            get { return _ped_id; }
            set { _ped_id = value; }
        }
        public int Cli_id
        {
            get { return _cli_id; }
            set { _cli_id = value; }
        }
        public string Ped_dtencomenda
        {
            get { return _ped_dtencomenda; }
            set { _ped_dtencomenda = value; }
        }
        public float Ped_valor
        {
            get { return _ped_valor; }
            set { _ped_valor = value; }
        }
        public string Ped_status
        {
            get { return _ped_status; }
            set { _ped_status = value; }
        }

        // Método alterar
        public void Alterar(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "update Pedido set " +
                         "CLI_ID = " + Cli_id + ", " +
                         "PED_DTENCOMENDA = '" + Ped_dtencomenda + "', " +
                         "PED_VALOR = " + Ped_valor + ", " +
                         "PED_STATUS = '" + Ped_status + "' " +
                         "where PED_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método excluir
        public void Excluir(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "delete from Pedido where PED_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método gravar
        public void Gravar()
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "insert into Pedido (CLI_ID, PED_DTENCOMENDA, PED_VALOR, PED_STATUS) values ( " +
                         Cli_id + ", " +
                         "'" + Ped_dtencomenda + "', " +
                         Ped_valor + ", " +
                         "'" + Ped_status + "', " +
                         ")";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            banco.ExecutaComando(sql);
        }

        // Método listar
        public DataSet Listar(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select PED_ID as Código, Cliente.CLI_NOMERAZAO as Cliente, PED_DTENCOMENDA as Data, PED_VALOR as Valor, PED_STATUS as Status from Pedido join Cliente on Cliente.CLI_ID = Pedido.CLI_ID where PED_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataSet(sql);
        }

        // Método listar pedido
        public SqlDataReader ListarPedido(int codigo)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select Cliente.CLI_NOMERAZAO, Pedido.PED_DTENCOMENDA from Pedido join Cliente on Cliente.CLI_ID = Pedido.CLI_ID where Pedido.PED_ID = " + codigo;

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.RetornaDataReader(sql);
        }

        // Método buscar codigo cliente
        public int BuscarCodigoCliente(string nome)
        {
            // Variável sql recebe o comando que será passado ao Banco
            String sql = "select Pedido.CLI_ID from Pedido join Cliente on Cliente.CLI_ID = Pedido.CLI_ID where Cliente.CLI_NOMERAZAO like '%"+ nome + "%'";

            // Instancia da classe cldBancoDados para executar o comando
            Sistema.Globais.cldBancoDados banco = new Sistema.Globais.cldBancoDados();
            return banco.ExecutaComandoInteiro(sql);
        }
    }
}
