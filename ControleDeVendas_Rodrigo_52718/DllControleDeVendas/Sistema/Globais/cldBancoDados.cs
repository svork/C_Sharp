using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DllControleDeVendas.Sistema.Globais
{
    public class cldBancoDados
    {        
        // Instancia uma conexão com o banco
        SqlConnection conexao = new SqlConnection(Properties.Settings.Default.Conexao);

        // Método para abrir uma conexão com o banco de dados
        public SqlConnection AbreBanco()
        {
            try
            {
                // Abre uma conexão com o banco                
                conexao.Open();                
            }
            catch (SqlException error)
            {
                // Se a conexão falhar, exibir mensagem
                Console.Write(error);
                throw error;
            }
            // Retorna a conexão
            return conexao;
        }

        // Método para fechar uma conexão
        public void FechaBanco()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (SqlException error)
            {
                // Se a fechar conexão falhar, exibir mensagem
                Console.Write(error);
                throw error;
            }
        }

        // Método para executar um comando SQL
        public void ExecutaComando(String sql)
        {
            try
            {
                // Abre conexão
                AbreBanco();

                // Cria objeto para executar o comando
                SqlCommand comando = new SqlCommand(sql);

                // Executa o comando
                comando.Connection = conexao;
                comando.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                // Em caso de erro, exibir mensagem
                Console.Write(error);
                throw error;
            }
            finally
            {
                // Fecha a conexão
                FechaBanco();
            }
        }
        
        // Método para executar um comando SQL que retorna um inteiro
        public int ExecutaComandoInteiro(String sql)
        {
            try
            {
                // Abre conexão
                AbreBanco();

                // Criando um Data Reader para receber os valores
                SqlDataReader dr = null;

                // Cria objeto para executar o comando
                SqlCommand comando = new SqlCommand(sql);

                // Executa o comando
                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                comando.CommandText = "select @@Identity;";

                // Guarda o resultado no objeto dr
                dr = comando.ExecuteReader();
                dr.Read();

                // Retorna os dados
                return (int)dr[0];
            }
            catch (SqlException error)
            {
                // Em caso de erro, exibir mensagem
                Console.Write(error);
                throw error;
            }
            finally
            {
                // Fecha a conexão
                FechaBanco();
            }
        }

        // Método para retornar um dataSet
        public DataSet RetornaDataSet(String sql)
        {
            try
            {
                // Abre conexão
                AbreBanco();

                // Criando um Data Adapter para receber os valores
                SqlDataAdapter daAdaptador = new SqlDataAdapter(sql,conexao);

                // Declara um DataAdapter
                DataSet dsDataSet = new DataSet();

                // Preencher o DataAdapter com o DataSet
                daAdaptador.Fill(dsDataSet);

                // Retorna os dados
                return dsDataSet;
            }
            catch (SqlException error)
            {
                // Em caso de erro, exibir mensagem
                Console.Write(error);
                throw error;
            }
            finally
            {
                // Fecha a conexão
                FechaBanco();
            }
        }

        // Método retorna um dataReader
        public  SqlDataReader RetornaDataReader(String sql)
        {
            try
            {
                // Abre conexão
                AbreBanco();

                // Cria objeto para executar o comando
                SqlCommand comando = new SqlCommand(sql);

                // Executa o comando
                comando.Connection = conexao;                

                // Retorna os dados
                return comando.ExecuteReader();
            }
            catch (SqlException error)
            {
                // Em caso de erro, exibir mensagem
                Console.Write(error);
                throw error;
            }           
        }
    }
}
