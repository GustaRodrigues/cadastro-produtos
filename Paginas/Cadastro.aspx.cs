using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Connection;

namespace WebApplication1
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Produtos sql = new Produtos();
            sql.IncluirProduto( nomeProduto.Text , valorUnitario.Text , int.Parse(quantidadeProdutos.Text) );
            limparCampos();
        }

        protected void limparCampos() 
        {
            nomeProduto.Text = "";
            valorUnitario.Text = "";
            quantidadeProdutos.Text = "";
        }
    }
}