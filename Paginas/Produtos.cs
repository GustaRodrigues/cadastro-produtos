using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Connection
{
    public class Produtos
    {
        public string Codigo { get; private set; }
        public string Nome { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }

        public SQLServer bancoSql;

        public Produtos()
        {
            try
            {
                bancoSql = new SQLServer();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void IncluirProduto(string nome, string valorUnitario, int quantidade)
        {
            try
            {
                string SQL = $" INSERT INTO EST.Produtos (Nome, ValorUnitario, Quantidade) VALUES ('{nome}', '{valorUnitario}' , {quantidade} ) ";
                bancoSql.SQLComando(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bancoSql.Close();
            }
        }

        public void AlterarProduto(string codigo, string nome, string valorUnitario, int quantidade)
        {
            try
            {
                string SQL = $" UPDATE EST.Produtos SET Nome = '{nome}' , ValorUnitario = '{valorUnitario}' , Quantidade = {quantidade} WHERE Codigo = '{codigo}' ";
                bancoSql.SQLComando(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }finally
            {
                bancoSql.Close();
            }
            
        }

        public void ApagarProduto(string codigo)
        {
            try
            {
                string SQL = $"DELETE FROM Est.Produtos WHERE Codigo = '{codigo}'";
                bancoSql.SQLComando(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bancoSql.Close();
            }
           
        }

    }
}