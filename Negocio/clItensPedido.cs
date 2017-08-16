using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
   public class clItensPedido
    {
        //Propriedades
        public string Banco { get; set; }
        public int itmCodigo { get; set; }
        public int pedCodigo { get; set; }
        public int proCodigo { get; set; }
        public string itmQtde { get; set; }
        public string itmUnitario { get; set; }
        public string itmSubtotal { get; set; }


        public void Gravar()
        {
            // Variável utilizada para "concatenar" texto de forma estruturada 
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Insert
            strQuery.Append("INSERT INTO tb_ItensPedido");

            strQuery.Append(" ( ");

            strQuery.Append(" pedCodigo");
            strQuery.Append(", proCodigo");
            strQuery.Append(", itmQtde");
            strQuery.Append(", itmUnitario");
            strQuery.Append(", itmSubtotal");




            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + pedCodigo + "'");
            strQuery.Append(", '" + proCodigo + "'");
            strQuery.Append(", '" + itmQtde.Replace(",", ".") + "'");
            strQuery.Append(", '" + itmUnitario.Replace(",", ".") + "'");
            strQuery.Append(", '" + itmSubtotal.Replace(",", ".") + "'");


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
            strQuery.Append(" UPDATE tb_ItensPedido");

            strQuery.Append(" SET ");

            strQuery.Append("pedCodigo = '" + pedCodigo + "'");
            strQuery.Append(", proCodigo = '" + proCodigo + "'");
            strQuery.Append(", itmQtde = '" + itmQtde.Replace(",", ".") + "'");
            strQuery.Append(", itmUnitario = '" + itmUnitario.Replace(",", ".") + "'");
            strQuery.Append(", itmSubtotal = '" + itmSubtotal.Replace(",", ".") + "'");



            strQuery.Append(" WHERE ");

            strQuery.Append(" imtCodigo = " + itmCodigo);

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());

        }

        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Delete
            strQuery.Append(" DELETE FROM tb_ItensPedido");
            strQuery.Append(" WHERE ");
            strQuery.Append(" itmCodigo = " + itmCodigo); ;

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public DataSet Pesquisar(int IDPed)
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select 
            strQuery.Append(" SELECT tb_ItensPedido.proCodigo [Código Produto], tb_Produtos.proNome [Nome Produto] , ");
            strQuery.Append(" tb_ItensPedido.itmQtde [Quantidade], tb_ItensPedido.itmUnitario [Valor Unitário], tb_ItensPedido.itmSubtotal [SubTotal]");
            strQuery.Append(" FROM tb_ItensPedido INNER JOIN tb_Produtos ");
            strQuery.Append(" ON tb_ItensPedido.proCodigo = tb_Produtos.proCodigo ");
            strQuery.Append(" WHERE tb_ItensPedido.pedCodigo = " + IDPed);

            //Executa Comando 
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }

        public SqlDataReader TotalPedido(int IDPed)
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select
            strQuery.Append("SELECT SUM(itmSubTotal) Total ");
            strQuery.Append("FROM tb_ItensPedido ");
            strQuery.Append("WHERE pedCodigo = " + IDPed);

            //Executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }
    }
}
