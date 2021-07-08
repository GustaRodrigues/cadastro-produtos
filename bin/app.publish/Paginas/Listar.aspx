<%@ Page Title="Produtos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="WebApplication1.Listar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <style>
        .row{
            margin-top:5pt;
        }
        .modal-dialog{
            width:80%;
        }
        input{
            max-width: 100%;
        }
    </style>

    <script type="text/javascript">
        function editarProduto(codigo, nome, valorUnitario, quantidade) {
            $("#editarProduto").modal();
            document.getElementById("<%=codigoProduto.ClientID%>").value = codigo;
            document.getElementById("<%=nomeProduto.ClientID%>").value = nome;
            document.getElementById("<%=valorUnitario.ClientID%>").value = valorUnitario;
            document.getElementById("<%=quantidadeProdutos.ClientID%>").value = quantidade;
        }
    </script>

    <div class="row text-center">
        <div class="col-md-12">
            <h2>Lista de Produtos</h2>
        </div>
    </div>

     <div class="row text-center">
        <div class="col-md-12">

            <asp:GridView ID="listaProdutos"
                runat="server" CssClass="table table-striped color-table text-align-center" 
                AutoGenerateColumns="false" OnRowDeleting="listaProdutos_RowDeleting" DataKeyNames="codigo" OnRowDataBound="listaProdutos_RowDataBound" OnRowEditing="listaProdutos_RowEditing">
                <Columns>

                    <asp:BoundField DataField="codigo" HeaderText="Código" ReadOnly="true"/>
                    <asp:BoundField DataField="nome" HeaderText="Nome"/>
                    <asp:BoundField DataField="valorUnitario" HeaderText="Valor Unitário"/>
                    <asp:BoundField DataField="Quantidade" HeaderText="Quantidade"/>
                    <asp:CommandField ShowEditButton="true" ButtonType="Button" HeaderText="Editar" />
                    <asp:CommandField ShowDeleteButton="true" ButtonType="Button" HeaderText="Deletar"/>
                
                </Columns>

            </asp:GridView> 

        </div>
    </div>

    <div class="modal fade" id="editarProduto" tabindex="-1" aria-labelledby="editarProdutolLabel" aria-hidden="true">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h3 class="modal-title">Editar Produto</h3>
          </div>
          <div class="modal-body">

             <div class="row text-center">
                <div class="col-md-12">
                    <label for="nomeProduto">Nome do produto</label>
                    <asp:TextBox ID="nomeProduto" ClientID="nomeProduto" runat="server" CssClass="form-control" required="true"></asp:TextBox>
                </div>
            </div>

            <div class="row text-center ">
                <div class="col-md-6">
                    <label for="valorUnitario">Valor Unitário</label>
                    <asp:TextBox ID="valorUnitario" ClientID="valorUnitario" runat="server" CssClass="form-control"  required="true"></asp:TextBox>
                </div>

                <div class="col col-md-6">
                    <label for="quantidadeProdutos">Quantidade</label>
                    <asp:TextBox ID="quantidadeProdutos" ClientID="quantidadeProdutos" runat="server" CssClass="form-control" required="true"></asp:TextBox>
                </div>
            </div>

            <div style="display:none;">
                <asp:TextBox ID="codigoProduto" ClientID="codigoProduto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

          </div>

          <div class="modal-footer">
            <button type="button" class="btn btn-close" data-dismiss="modal">Close</button>
            <asp:Button ID="salvarAlteracao" runat="server" OnClick="salvarAlteracao_Click" Text="Salvar" CssClass="btn btn-success"/>
          </div>

        </div>
      </div>
    </div>

</asp:Content>
