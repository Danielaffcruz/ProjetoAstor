using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clFuncionarios
    {
        //Propriedades
        public string Banco { get; set; }
        public int funCodigo { get; set; }
        public string funVendedor { get; set; }
        public string funOutros { get; set; }
        public string funNome { get; set; }
        public string funSobrenome { get; set; }
        public string funRemuneracao { get; set; }
        public string funCPF { get; set; }
        public string funRG { get; set; }
        public string funCEP { get; set; }
        public string funEndereco { get; set; }
        public string funNumero { get; set; }
        public string funBairro { get; set; }
        public string funCidade { get; set; }
        public string funEstado { get; set; }
        public string funEmail { get; set; }
        public string funTelefone { get; set; }
        public string funCelular { get; set; }
        public string funObservacao { get; set; }

        public void Gravar()
        {
            // Variável utilizada para "concatenar" texto de forma estruturada 
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Insert
            strQuery.Append("INSERT INTO tb_Funcionarios");

            strQuery.Append(" ( ");

            strQuery.Append(" funVendedor ");
            strQuery.Append(", funOutros ");
            strQuery.Append(", funNome ");
            strQuery.Append(", funSobrenome ");
            strQuery.Append(", funRemuneracao ");
            strQuery.Append(", funCPF ");
            strQuery.Append(", funRG ");
            strQuery.Append(", funCEP ");
            strQuery.Append(", funEndereco ");
            strQuery.Append(", funNumero");
            strQuery.Append(", funBairro ");
            strQuery.Append(", funCidade ");
            strQuery.Append(", funEstado ");
            strQuery.Append(", funEmail ");
            strQuery.Append(", funTelefone ");
            strQuery.Append(", funCelular ");
            strQuery.Append(", funOBS ");

            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ( ");

            strQuery.Append(" '" + funVendedor + "'");
            strQuery.Append(", '" + funOutros + "'");
            strQuery.Append(", '" + funNome + "'");
            strQuery.Append(", '" + funSobrenome + "'");
            strQuery.Append(", '" + funRemuneracao + "'");
            strQuery.Append(", '" + funCPF + "'");
            strQuery.Append(", '" + funRG + "'");
            strQuery.Append(", '" + funCEP + "'");
            strQuery.Append(", '" + funEndereco + "'");
            strQuery.Append(", '" + funNumero + "'");
            strQuery.Append(", '" + funBairro + "'");
            strQuery.Append(", '" + funCidade + "'");
            strQuery.Append(", '" + funEstado + "'");
            strQuery.Append(", '" + funEmail + "'");
            strQuery.Append(", '" + funTelefone + "'");
            strQuery.Append(", '" + funCelular + "'");
            strQuery.Append(", '" + funObservacao + "'");



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
            strQuery.Append(" UPDATE tb_Funcionarios ");

            strQuery.Append(" SET ");

            strQuery.Append("funVendedor = '" + funVendedor + "'");
            strQuery.Append(", funOutros = '" + funOutros + "'");
            strQuery.Append(", funNome = '" + funNome + "'");
            strQuery.Append(", funSobrenome = '" + funSobrenome + "'");
            strQuery.Append(", funRemuneracao = '" + funRemuneracao + "'");
            strQuery.Append(", funCPF = '" + funCPF + "'");
            strQuery.Append(", funRG = '" + funRG + "'");
            strQuery.Append(", funCEP = '" + funCEP + "'");
            strQuery.Append(", funEndereco = '" + funEndereco + "'");
            strQuery.Append(", funNumero = '" + funNumero + "'");
            strQuery.Append(", funBairro = '" + funBairro + "'");
            strQuery.Append(", funCidade = '" + funCidade + "'");
            strQuery.Append(", funEstado = '" + funEstado + "'");
            strQuery.Append(", funEmail = '" + funEmail + "'");
            strQuery.Append(", funTelefone = '" + funTelefone + "'");
            strQuery.Append(", funCelular = '" + funCelular + "'");
            strQuery.Append(", funOBS = '" + funObservacao + "'");


            strQuery.Append(" WHERE ");

            strQuery.Append(" funCodigo = " + funCodigo);

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());

        }

        public void Excluir()
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Delete
            strQuery.Append(" DELETE FROM tb_Funcionarios");
            strQuery.Append(" WHERE ");
            strQuery.Append(" funCodigo = " + funCodigo);

            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            clAcessoDB.ExecutaComando(strQuery.ToString());
        }

        public DataSet Pesquisar(string Campo, string Filtro)
        {
            StringBuilder strQuery = new StringBuilder();

            //Montagem do Select
            strQuery.Append(" SELECT funCodigo Código, funNome Nome, funSobrenome Sobrenome, funRemuneracao [Remuneração], funCPF CPF, funRG RG, funEmail Email, funCEP CEP, funEndereco [Endereço], funNumero [Número], funBairro Bairro, funCidade Cidade, funEstado Estado, funTelefone Telefone, funCelular Celular, funOBS [Observação], funVendedor Vendedor, funOutros [Geral/Outros] ");
            strQuery.Append(" FROM tb_Funcionarios");
            if (Campo != string.Empty && Filtro != string.Empty)
            {
                strQuery.Append(" WHERE ");
                strQuery.Append(Campo + " LIKE '" + "%" + Filtro + "%" + "'");
            }
            strQuery.Append(" ORDER BY funNome ");

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
            strQuery.Append(" FROM tb_Funcionarios ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" funCodigo = " + funCodigo);


            //Instancia a classe clAcessoDB e executa o comando
            clAcessoDB clAcessoDB = new clAcessoDB();
            clAcessoDB.vConexao = Banco;
            return clAcessoDB.RetornaDataReader(strQuery.ToString());
        }

    }
}
