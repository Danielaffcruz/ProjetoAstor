using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clClientes
    {
        //Propriedades
        public string Banco { get; set; }
        public int cliCodigo { get; set; }
        public string cliFisica { get; set; }
        public string cliJuridica { get; set; }
        public string cliRazaoSocial { get; set; }
        public string cliNomeFantasia { get; set; }
        public string cliCNPJ { get; set; }
        public string cliInsEsta { get; set; }
        public string cliEmail { get; set; }
        public string cliCEP { get; set; }
        public string cliEndereco { get; set; }
        public string cliNumero { get; set; }
        public string cliBairro { get; set; }
        public string cliCidade { get; set; }
        public string cliEstado { get; set; }
        public string cliTelefone1 { get; set; }
        public string cliTelefone2 { get; set; }
        public string cliCelular { get; set; }
        public string cliSite { get; set; }
        public string cliObservacao { get; set; }

        public void Gravar()
        {
            // Variável utilizada para "concatenar" texto de forma estruturada 
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Insert
            strQuery.Append("INSERT INTO tb_Clientes");

            strQuery.Append(" ( ");

            strQuery.Append(" cliFisica ");
            strQuery.Append(", cliJuridica ");
            strQuery.Append(", cliRazaoSocial ");
            strQuery.Append(", cliNomeFantasia ");
            strQuery.Append(", cliCNPJ ");
            strQuery.Append(", cliInsEsta ");
            strQuery.Append(", cliEmail ");
            strQuery.Append(", cliCEP ");
            strQuery.Append(", cliEndereco ");
            strQuery.Append(", cliNumero");
            strQuery.Append(", cliBairro ");
            strQuery.Append(", cliCidade ");
            strQuery.Append(", cliEstado ");
            strQuery.Append(", cliTelefone1 ");
            strQuery.Append(", cliTelefone2 ");
            strQuery.Append(", cliCelular ");
            strQuery.Append(", cliSite ");
            strQuery.Append(", cliOBS ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + cliFisica + "'");
            strQuery.Append(", '" + cliJuridica + "'");
            strQuery.Append(", '" + cliRazaoSocial + "'");
            strQuery.Append(", '" + cliNomeFantasia + "'");
            strQuery.Append(", '" + cliCNPJ + "'");
            strQuery.Append(", '" + cliInsEsta + "'");
            strQuery.Append(", '" + cliEmail + "'");
            strQuery.Append(", '" + cliCEP + "'");
            strQuery.Append(", '" + cliEndereco + "'");
            strQuery.Append(", '" + cliNumero + "'");
            strQuery.Append(", '" + cliBairro + "'");
            strQuery.Append(", '" + cliCidade + "'");
            strQuery.Append(", '" + cliEstado + "'");
            strQuery.Append(", '" + cliTelefone1 + "'");
            strQuery.Append(", '" + cliTelefone2 + "'");
            strQuery.Append(", '" + cliCelular + "'");
            strQuery.Append(", '" + cliSite + "'");
            strQuery.Append(", '" + cliObservacao + "'");



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
            strQuery.Append(" UPDATE tb_Clientes ");

            strQuery.Append(" SET ");

            strQuery.Append("cliFisica = '" + cliFisica + "'");
            strQuery.Append(", cliJuridica = '" + cliJuridica + "'");
            strQuery.Append(", cliRazaoSocial = '" + cliRazaoSocial + "'");
            strQuery.Append(", cliNomeFantasia = '" + cliNomeFantasia + "'");
            strQuery.Append(", cliCNPJ = '" + cliCNPJ + "'");
            strQuery.Append(", cliInsEsta = '" + cliInsEsta + "'");
            strQuery.Append(", cliEmail = '" + cliEmail + "'");
            strQuery.Append(", cliCEP = '" + cliCEP + "'");
            strQuery.Append(", cliEndereco = '" + cliEndereco + "'");
            strQuery.Append(", cliNumero = '" + cliNumero + "'");
            strQuery.Append(", cliBairro = '" + cliBairro + "'");
            strQuery.Append(", cliCidade = '" + cliCidade + "'");
            strQuery.Append(", cliEstado = '" + cliEstado + "'");
            strQuery.Append(", cliTelefone1 = '" + cliTelefone1 + "'");
            strQuery.Append(", cliTelefone2 = '" + cliTelefone2 + "'");
            strQuery.Append(", cliCelular = '" + cliCelular + "'");
            strQuery.Append(", cliSite = '" + cliSite + "'");
            strQuery.Append(", cliOBS = '" + cliObservacao + "'");


            strQuery.Append(" WHERE ");

            strQuery.Append(" cliCodigo = " + cliCodigo);

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());

        }

        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Delete
            strQuery.Append(" DELETE FROM tb_Clientes");
            strQuery.Append(" WHERE ");
            strQuery.Append(" cliCodigo = " + cliCodigo);

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public DataSet Pesquisar(string Campo, string Filtro)
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select
            strQuery.Append(" SELECT cliCodigo CODIGO, cliRazaoSocial [Razão Social/Nome], cliNomeFantasia [Nome Fantasia/Sobrenome], cliCNPJ [CNPJ/CPF], cliInsEsta [Insc. Estadual/RG], cliEmail Email, cliCEP CEP, cliEndereco Endereço, cliNumero Número, cliBairro Bairro, cliCidade Cidade, cliEstado Estado, cliTelefone1 Telefone1, cliTelefone2 Telefone2, cliCelular Celular, cliSite Site, cliOBS Observação, cliFisica [Pessoa Física], cliJuridica [Pessoa Jurídica] ");
            strQuery.Append(" FROM tb_Clientes");
            if (Campo != string.Empty && Filtro != string.Empty)
            {
                strQuery.Append(" WHERE ");
                strQuery.Append(Campo + " LIKE '" + "%" + Filtro + "%" + "'");
            }
            strQuery.Append(" ORDER BY cliRazaoSocial ");

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
            strQuery.Append(" FROM tb_Clientes ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" cliCodigo = " + cliCodigo);


            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader CarregarClientes()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select 
            strQuery.Append(" SELECT cliRazaoSocial ");
            strQuery.Append(" FROM tb_Clientes ");
            strQuery.Append(" ORDER BY cliRazaoSocial ");


            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader PesquisarNome(string cliRazaoSocial)
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select 
            strQuery.Append(" SELECT cliCodigo");
            strQuery.Append(" FROM tb_Clientes ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" cliRazaoSocial =  '" + cliRazaoSocial + "'");


            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }
    }
}
