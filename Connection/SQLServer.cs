using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication1.Connection
{
    public class SQLServer
    {
        public string stringConexao;
        public SqlConnection conectarBanco;

        public SQLServer()
        {
            try
            {
                stringConexao = ConfigurationManager.ConnectionStrings["StringConect"].ConnectionString; 
                conectarBanco = new SqlConnection(stringConexao);
                conectarBanco.Open();
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            conectarBanco.Close();
        }

        public DataTable SQLQuery(string SQL)
        {
            DataTable tabelaDadosProdutos = new DataTable();
            try
            {
                SqlCommand comandoSql = new SqlCommand(SQL, conectarBanco);
                SqlDataReader lerComando = comandoSql.ExecuteReader();
                tabelaDadosProdutos.Load(lerComando);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tabelaDadosProdutos;
        }

        public string SQLComando(string SQL)
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand(SQL, conectarBanco);
                comandoSql.ExecuteNonQuery();
                return "Comando executado";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}