using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clTransportadoras
    {
        //Propriedades
        public string Banco { get; set; }
        public int traCodigo { get; set; }
        public string traRazaoSocial { get; set; }
        public string traNomeFantasia { get; set; }
        public string traCNPJ { get; set; }
        public string traEmail { get; set; }
        public string traCEP { get; set; }
        public string traEndereco { get; set; }
        public string traNumero { get; set; }
        public string traBairro { get; set; }
        public string traCidade { get; set; }
        public string traEstado { get; set; }
        public string traTelefone { get; set; }
        public string traTelefone2 { get; set; }
        public string traObservacao { get; set; }

        public void Gravar()
        {
            // Variável utilizada para "concatenar" texto de forma estruturada 
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Insert
            strQuery.Append("INSERT INTO tb_Transportadoras");

            strQuery.Append(" ( ");

            strQuery.Append(" traRazaoSocial ");
            strQuery.Append(", traNomeFantasia ");
            strQuery.Append(", traCNPJ ");
            strQuery.Append(", traEmail ");
            strQuery.Append(", traTelefone ");
            strQuery.Append(", traTelefone2 ");
            strQuery.Append(", traCEP ");
            strQuery.Append(", traEndereco ");
            strQuery.Append(", traNumero");
            strQuery.Append(", traBairro ");
            strQuery.Append(", traCidade ");
            strQuery.Append(", traEstado ");
            strQuery.Append(", traOBS ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + traRazaoSocial + "'");
            strQuery.Append(", '" + traNomeFantasia + "'");
            strQuery.Append(", '" + traCNPJ + "'");
            strQuery.Append(", '" + traEmail + "'");
            strQuery.Append(", '" + traTelefone + "'");
            strQuery.Append(", '" + traTelefone2 + "'");
            strQuery.Append(", '" + traCEP + "'");
            strQuery.Append(", '" + traEndereco + "'");
            strQuery.Append(", '" + traNumero + "'");
            strQuery.Append(", '" + traBairro + "'");
            strQuery.Append(", '" + traCidade + "'");
            strQuery.Append(", '" + traEstado + "'");
            strQuery.Append(", '" + traObservacao + "'");



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
            strQuery.Append(" UPDATE tb_Transportadoras ");

            strQuery.Append(" SET ");

            strQuery.Append("traRazaoSocial = '" + traRazaoSocial + "'");
            strQuery.Append(", traNomeFantasia = '" + traNomeFantasia + "'");
            strQuery.Append(", traCNPJ = '" + traCNPJ + "'");
            strQuery.Append(", traEmail = '" + traEmail + "'");
            strQuery.Append(", traTelefone = '" + traTelefone + "'");
            strQuery.Append(", traTelefone2 = '" + traTelefone2 + "'");
            strQuery.Append(", traCEP = '" + traCEP + "'");
            strQuery.Append(", traEndereco = '" + traEndereco + "'");
            strQuery.Append(", traNumero = '" + traNumero + "'");
            strQuery.Append(", traBairro = '" + traBairro + "'");
            strQuery.Append(", traCidade = '" + traCidade + "'");
            strQuery.Append(", traEstado = '" + traEstado + "'");
            strQuery.Append(", traOBS = '" + traObservacao + "'");


            strQuery.Append(" WHERE ");

            strQuery.Append(" traCodigo = " + traCodigo);

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());

        }

        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Delete
            strQuery.Append(" DELETE FROM tb_Transportadoras");
            strQuery.Append(" WHERE ");
            strQuery.Append(" traCodigo = " + traCodigo);

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public DataSet Pesquisar(string Campo, string Filtro)
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select
            strQuery.Append(" SELECT traCodigo CODIGO, traRazaoSocial [Razão Social], traNomeFantasia [Nome Fantasia], traCNPJ CNPJ, traEmail Email,  traTelefone Telefone1, traTelefone2 Telefone2, traCEP CEP, traEndereco Endereço, traNumero Número, traBairro Bairro, traCidade Cidade, traEstado Estado, traOBS Observação ");
            strQuery.Append(" FROM tb_Transportadoras");
            if (Campo != string.Empty && Filtro != string.Empty)
            {
                strQuery.Append(" WHERE ");
                strQuery.Append(Campo + " LIKE '" + "%" + Filtro + "%" + "'");
            }
            strQuery.Append(" ORDER BY traRazaoSocial ");

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataSet(strQuery.ToString());
        }

        public SqlDataReader PesquisarCodigo()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select 
            strQuery.Append(" SELECT * ");
            strQuery.Append(" FROM tb_Transportadoras ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" traCodigo = " + traCodigo);


            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }

    }
}
