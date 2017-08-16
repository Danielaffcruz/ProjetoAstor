using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clAcessoDB
    {
        //Variavel para receber a string de conexão
        public string vConexao = "";

        //Método responsável por abrir a conexão com o banco de dados
        public SqlConnection AbreBanco()
        {
            //Abre Conexão com o bando de Dados
            SqlConnection conn = new SqlConnection(vConexao);
            conn.Open();
            return conn;

        }

        //Método responsável por fechar a conexão com o banco de dados
        public void FecharBanco(SqlConnection conn)
        {
            //Fecha a Conexão com o banco de dados
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        // Método responsavel por executar comandos (INSERT, UPDATE, DELETE) NO BANCO DE DADOS
        public void ExecutaComando(string strQuery)
        {
            // criar o objeto de conexão
            SqlConnection conn = new SqlConnection();
            try
            {
                // Abre a conexao com o banco de dados
                conn = AbreBanco();
                // Cria o objeto de comando
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;
                //Passa os valores da query SQL,tipo do comando, conexao e executa o comando
                cmdComando.ExecuteNonQuery();
            }
            //tratamento de excessoes
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Em caso de erro ou nao o finally é executado para fechar a conexao com o banco de dados
                FecharBanco(conn);
            }
        }

        /* DataSet é utilizado para retornar um volume grande de registros
         * utilizado principalmente para o componente DataGridView
         */
        public DataSet RetornaDataSet(string strQuery)
        {
            //Cria o objeto e conexão 
            SqlConnection conn = new SqlConnection();
            try
            {
                //Abre a conexão com o banco de dados
                conn = AbreBanco();
                //Cria o objeto de Comando 
                SqlCommand cmdComando = new SqlCommand();
                //Passa os valores da query SQL, tipo do comando, conexao e executa comando
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;
                //Declara um dataadapter
                SqlDataAdapter daAdaptador = new SqlDataAdapter();
                //Declara um DataSet
                DataSet dsDataSet = new DataSet();
                //Passa o comando a ser executado pelo dataadapter
                daAdaptador.SelectCommand = cmdComando;
                // O DataAdapter faz a conexao com o banco de dados,
                //Carrega o DataSet e fecha a conexão
                daAdaptador.Fill(dsDataSet);
                //Retorna o DataSet carregado
                return dsDataSet;
                //Tratamento de excessões
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Em caso de erro ou não, o finally
                //é executado para fechar a conexão com o banco de dados
                FecharBanco(conn);
            }
        }

        public SqlDataReader RetornaDataReader(string strQuery)
        {
            //Cria o objeto e conexão 
            SqlConnection conn = new SqlConnection();
            try
            {
                //Abre a conexão com o banco de dados
                conn = AbreBanco();
                //Cria o objeto de Comando 
                SqlCommand cmdComando = new SqlCommand();
                //Passa os valores da query SQL, tipo do comando, conexao e executa comando
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;

                //Retorna o Comando executando a leitura 
                return cmdComando.ExecuteReader(CommandBehavior.CloseConnection);

                //Tratamento de excessões
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public int ExecutaComandoRetorno(string strQuery)
        {
            // criar o objeto de conexão
            SqlConnection conn = new SqlConnection();
            //declara um novo datareader
            SqlDataReader dr;
            try
            {
                // Abre a conexao com o banco de dados
                conn = AbreBanco();
                // Cria o objeto de comando
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;
                //Passa os valores da query SQL,tipo do comando, conexao e executa o comando
                cmdComando.ExecuteNonQuery();
                //Cria uma nova query, que busca o valor
                //do identity gerado pelo banco de dados
                cmdComando.CommandText = "SELECT @@Identity;";
                dr = cmdComando.ExecuteReader(CommandBehavior.CloseConnection);
                //Le o DataReader
                dr.Read();
                //Retorna o valor
                return Convert.ToInt32(dr.GetValue(0));
            }
            //tratamento de excessoes
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Em caso de erro ou nao o finally é executado para fechar a conexao com o banco de dados
                FecharBanco(conn);
            }
        }
    }
}
