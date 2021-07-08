using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Connection;

namespace WebApplication1
{
    public partial class Listar : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                carregarGrid();
        }

        public void carregarGrid()
        {
            string buscar = "SELECT Codigo, Nome, ValorUnitario, Quantidade FROM Est.Produtos order by Nome";
            SQLServer listarProdutos = new SQLServer();
            DataTable tableProdutos = listarProdutos.SQLQuery(buscar);

            listaProdutos.DataSource = tableProdutos;
            listaProdutos.DataBind();
            
        }
        
        protected void listaProdutos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string codigo = listaProdutos.DataKeys[e.RowIndex].Value.ToString();
            Produtos produtos = new Produtos();
            produtos.ApagarProduto(codigo);
            carregarGrid();
        }

        protected void listaProdutos_RowDataBound(object sender, GridViewRowEventArgs e) 
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string w = e.Row.Cells[0].Text.ToString();
                string x = HttpUtility.HtmlDecode(e.Row.Cells[1].Text.ToString());
                string y = e.Row.Cells[2].Text.ToString();
                string z = e.Row.Cells[3].Text.ToString();
                /*$"return editarProduto('{w}, {x}, {y}, {z}');"*/

                ((Button)e.Row.Cells[4].Controls[0]).OnClientClick = "return editarProduto(\""+ w + "\", \"" + x + "\", \"" + y + "\" , \"" + z + "\")";
                ((Button)e.Row.Cells[5].Controls[0]).OnClientClick = "if(!confirm('Deseja excluir o produto selecionado?')){ return false; };";
                //return editarProduto
            }
        }

        protected void listaProdutos_RowEditing(object sender, GridViewEditEventArgs e) 
        {
            return;
        }

        protected void salvarAlteracao_Click(object sender, EventArgs e)
        {
            Produtos sql = new Produtos();
            sql.AlterarProduto(codigoProduto.Text, nomeProduto.Text, valorUnitario.Text, Convert.ToInt32(quantidadeProdutos.Text));
            carregarGrid();

        }
    }
}