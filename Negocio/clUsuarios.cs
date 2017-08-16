using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clUsuarios
    {
        //Propriedades
        public string Banco { get; set; }
        public int    usrCodigo { get; set; }
        public string usrNome { get; set; }
        public string usrSobrenome { get; set; }
        public string usrUsuario { get; set; }
        public string usrSenha { get; set; }
        public string usrEmail { get; set; }
        public string usrPerClientes { get; set; }
        public string usrPerFuncionarios { get; set; }
        public string usrPerProdutos { get; set; }
        public string usrPerTransportadoras { get; set; }
        public string usrPerUsuarios { get; set; }
        public string usrPerPedidos { get; set; }


        public void Gravar()
        {
            // Variável utilizada para "concatenar" texto de forma estruturada 
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Insert
            strQuery.Append("INSERT INTO tb_Usuarios");

            strQuery.Append(" ( ");

            strQuery.Append(" usuNome ");
            strQuery.Append(", usuSobrenome ");
            strQuery.Append(", usuUsuario ");
            strQuery.Append(", usuSenha ");
            strQuery.Append(", usuEmail ");
            strQuery.Append(", usuClientes ");
            strQuery.Append(", usuFuncionarios ");
            strQuery.Append(", usuProdutos ");
            strQuery.Append(", usuTransportadoras ");
            strQuery.Append(", usuUsuarios ");
            strQuery.Append(", usuPedidos ");



            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + usrNome + "'");
            strQuery.Append(", '" + usrSobrenome + "'");
            strQuery.Append(", '" + usrUsuario + "'");
            strQuery.Append(", '" + usrSenha + "'");
            strQuery.Append(", '" + usrEmail + "'");
            strQuery.Append(", '" + usrPerClientes + "'");
            strQuery.Append(", '" + usrPerFuncionarios + "'");
            strQuery.Append(", '" + usrPerProdutos + "'");
            strQuery.Append(", '" + usrPerTransportadoras + "'");
            strQuery.Append(", '" + usrPerUsuarios + "'");
            strQuery.Append(", '" + usrPerPedidos + "'");


            strQuery.Append(" ); ");

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public void Alterar()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Update
            strQuery.Append(" UPDATE tb_Usuarios ");

            strQuery.Append(" SET ");

            strQuery.Append("usuNome = '" + usrNome + "'");
            strQuery.Append(", usuSobrenome = '" + usrSobrenome + "'");
            strQuery.Append(", usuUsuario = '" + usrUsuario + "'");
            strQuery.Append(", usuSenha = '" + usrSenha + "'");
            strQuery.Append(", usuEmail = '" + usrEmail + "'");
            strQuery.Append(", usuClientes = '" + usrPerClientes + "'");
            strQuery.Append(", usuFuncionarios = '" + usrPerFuncionarios + "'");
            strQuery.Append(", usuProdutos = '" + usrPerProdutos + "'");
            strQuery.Append(", usuTransportadoras = '" + usrPerTransportadoras + "'");
            strQuery.Append(", usuUsuarios = '" + usrPerUsuarios + "'");
            strQuery.Append(", usuPedidos = '" + usrPerPedidos + "'");


            strQuery.Append(" WHERE ");

            strQuery.Append(" usuCodigo = " + usrCodigo);

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());

        }

        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Delete
            strQuery.Append(" DELETE FROM tb_Usuarios");
            strQuery.Append(" WHERE ");
            strQuery.Append(" usuCodigo = " + usrCodigo); ;

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public DataSet PesquisarData(string Campo, string Filtro)
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select
            strQuery.Append(" SELECT usuCodigo CÓDIGO, usuNome Nome, usuSobrenome Sobrenome, usuUsuario Usuário, usuEmail EMAIL, usuClientes Clientes, usuFuncionarios Funcionários, usuProdutos Produtos, usuTransportadoras Transportadoras, usuUsuarios Usuario, usuPedidos Pedidos ");
            strQuery.Append(" FROM tb_Usuarios");
            if (Campo != string.Empty && Filtro != string.Empty)
            {
                strQuery.Append(" WHERE ");
                strQuery.Append(Campo + " LIKE '" + "%" + Filtro + "%" + "'");
            }
            strQuery.Append(" ORDER BY usuNome ");

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }

        public SqlDataReader PesquisarReader(string usrUsuario, string usrSenha)
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select 
            strQuery.Append(" SELECT usuUsuario, usuSenha, usuClientes, usuFuncionarios, usuProdutos, usuTransportadoras, usuUsuarios, usuPedidos ");
            strQuery.Append(" FROM tb_Usuarios ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" usuUsuario = '" + usrUsuario + "'");
            strQuery.Append(" AND ");
            strQuery.Append(" usuSenha = '" + usrSenha + "'");


            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader PesquisarReader2()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select 
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tb_Usuarios ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" usuCodigo = " + usrCodigo);


            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }
    }
}
