using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clProduto
    {
        //Propriedades
        public string Banco { get; set; }
        public int proCodigo { get; set; }
        public string proCodFabrica { get; set; }
        public string proNome { get; set; }
        public string proDataCadastro { get; set; }
        public string proCategoria { get; set; }
        public string proMaterial { get; set; }
        public string proGrupo { get; set; }
        public string proCor { get; set; }
        public string proFornecedor { get; set; }
        public string proValorUnitario { get; set; }
        public string proMinVenda { get; set; }
        public string proQtdeEstoque { get; set; }

        public void Gravar()
        {
            // Variável utilizada para "concatenar" texto de forma estruturada 
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Insert
            strQuery.Append("INSERT INTO tb_Produtos");

            strQuery.Append(" ( ");

            strQuery.Append(" proCodFabrica ");
            strQuery.Append(", proNome ");
            strQuery.Append(", proDataCadastro ");
            strQuery.Append(", proCategoria ");
            strQuery.Append(", proMaterial ");
            strQuery.Append(", proGrupo ");
            strQuery.Append(", proCor ");
            strQuery.Append(", proFornecedor ");
            strQuery.Append(", proValorUnitario ");
            strQuery.Append(", proMinVenda ");
            strQuery.Append(", proQtdeEstoque ");


            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + proCodFabrica + "'");
            strQuery.Append(", '" + proNome + "'");
            strQuery.Append(", '" + proDataCadastro + "'");
            strQuery.Append(", '" + proCategoria + "'");
            strQuery.Append(", '" + proMaterial + "'");
            strQuery.Append(", '" + proGrupo + "'");
            strQuery.Append(", '" + proCor + "'");
            strQuery.Append(", '" + proFornecedor + "'");
            strQuery.Append(", '" + proValorUnitario.Replace(",", ".") + "'");
            strQuery.Append(", '" + proMinVenda + "'");
            strQuery.Append(", '" + proQtdeEstoque + "'");



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
            strQuery.Append(" UPDATE tb_Produtos ");

            strQuery.Append(" SET ");

            strQuery.Append(" proCodFabrica = '" + proCodFabrica + "'");
            strQuery.Append(", proNome = '" + proNome + "'");
            strQuery.Append(", proDataCadastro = '" + proDataCadastro + "'");
            strQuery.Append(", proCategoria = '" + proCategoria + "'");
            strQuery.Append(", proMaterial = '" + proMaterial + "'");
            strQuery.Append(", proGrupo = '" + proGrupo + "'");
            strQuery.Append(", proCor = '" + proCor + "'");
            strQuery.Append(", proFornecedor = '" + proFornecedor + "'");
            strQuery.Append(", proValorUnitario = '" + proValorUnitario.Replace(",", ".") + "'");
            strQuery.Append(", proMinVenda = '" + proMinVenda + "'");
            strQuery.Append(", proQtdeEstoque = '" + proQtdeEstoque + "'");

            strQuery.Append(" WHERE ");

            strQuery.Append(" proCodigo = " + proCodigo);

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());

        }

        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Delete
            strQuery.Append(" DELETE FROM tb_Produtos");
            strQuery.Append(" WHERE ");
            strQuery.Append(" proCodigo = " + proCodigo); ;

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public DataSet Pesquisar(string Campo, string Filtro)
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select
            strQuery.Append(" SELECT tb_Produtos.proCodigo [CÓDIGO], tb_Produtos.proCodFabrica [Código Fabrica], tb_Produtos.proNome Nome, tb_Produtos.proDataCadastro [Data de Cadastro], tb_Produtos.proCategoria [Categoria], tb_Produtos.proMaterial Material, tb_Produtos.proGrupo Grupo, tb_Produtos.proCor Cor, tb_Produtos.proFornecedor Fornecedor, tb_Produtos.proValorUnitario [Valor Unitário], tb_Produtos.proMinVenda [Mínimo Venda], tb_Produtos.proQtdeEstoque [Quantidade em Estoque]");
            strQuery.Append(" FROM tb_Produtos ");
            if (Campo != string.Empty && Filtro != string.Empty)
            {
                strQuery.Append(" WHERE ");
                strQuery.Append(Campo + " LIKE '" + "%" + Filtro + "%" + "'");
            }
            strQuery.Append(" ORDER BY tb_Produtos.proNome  ");

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }

        public SqlDataReader PesquisarCodigo(int proCodigo)
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select 
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tb_Produtos ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" proCodigo = " + proCodigo);


            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader PesquisarCodigo2()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select 
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tb_Produtos ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" proCodigo = " + proCodigo);


            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }

    }
}
