using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clPedido
    {
        //propriedades
        public string Banco { get; set; }
        public int pedCodigo { get; set; }
        public string pedData { get; set; }
        public int cliCodigo { get; set; }
        public string funNome { get; set; }

        public int Gravar()
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do insert
            strQuery.Append(" INSERT INTO tb_Pedidos");

            strQuery.Append(" ( ");

            strQuery.Append(" pedData ");
            strQuery.Append(", cliCodigo ");
            strQuery.Append(", funNome ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + pedData + "'");
            strQuery.Append(", '" + cliCodigo + "'");
            strQuery.Append(", '" + funNome + "'");

            strQuery.Append(" ); ");

            //instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.ExecutaComandoRetorno(strQuery.ToString());
        }

        public void Alterar()
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do update
            strQuery.Append(" UPDATE tb_Pedidos ");

            strQuery.Append(" SET ");

            strQuery.Append(" pedData = '" + pedData + "'");
            strQuery.Append(", cliCodigo = '" + cliCodigo + "'");
            strQuery.Append(", funNome = '" + funNome + "'");

            strQuery.Append(" WHERE ");

            strQuery.Append(" pedCodigo = " + pedCodigo);

            //instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do delete
            strQuery.Append(" DELETE FROM tb_Pedidos ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" pedCodigo = " + pedCodigo);

            //instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public DataSet Pesquisar(string Campo, string Filtro)
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do select
            strQuery.Append(" SELECT tb_Pedidos.pedCodigo [Código Pedido], tb_Pedidos.pedData [Data Pedido], tb_Pedidos.funNome [Vendedor], tb_Clientes.cliRazaoSocial Cliente");
            strQuery.Append(" FROM tb_Clientes INNER JOIN ");
            strQuery.Append(" tb_Pedidos ON dbo.tb_Clientes.cliCodigo = tb_Pedidos.cliCodigo ");
            if (Campo != string.Empty && Filtro != string.Empty)
            {
                strQuery.Append(" WHERE ");
                strQuery.Append(Campo + " LIKE '" + "%" + Filtro + "%" + "'");
            }
            strQuery.Append(" ORDER BY tb_Pedidos.pedCodigo DESC ");

            //executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }
      
        public SqlDataReader Pesquisar(int Pedido)
        {
            StringBuilder strQuery = new StringBuilder();

            //montagem do select
            strQuery.Append(" SELECT tb_Pedidos.pedCodigo, tb_Pedidos.pedData, tb_Pedidos.funNome, tb_Clientes.cliRazaoSocial Cliente ");
            strQuery.Append(" FROM tb_Clientes INNER JOIN ");
            strQuery.Append(" tb_Pedidos ON dbo.tb_Clientes.cliCodigo = tb_Pedidos.cliCodigo ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" pedCodigo = " + Pedido);

            //executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }

    }
}
