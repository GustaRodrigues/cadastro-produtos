<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebApplication1.Cadastro" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>
        input{
            max-width: 100%;
        }
        .row{
            margin-top:5pt;
        }
    </style>

    <div class="row text-center">
        <div class="col-md-12">
           <h2>Cadastro de Produtos</h2>
        </div>
    </div>

    <div class="row text-center">
        <div class="col-md-12">
            <label for="nomeProduto">Nome do produto</label>
            <asp:TextBox ID="nomeProduto" runat="server" CssClass="form-control" required="true"></asp:TextBox>
        </div>
    </div>

    <div class="row text-center ">
        <div class="col-md-6">
            <label for="valorUnitario">Valor Unitário</label>
            <asp:TextBox ID="valorUnitario" runat="server" CssClass="form-control"  required="true"></asp:TextBox>
        </div>

        <div class="col col-md-6">
            <label for="quantidadeProdutos">Quantidade</label>
            <asp:TextBox ID="quantidadeProdutos" runat="server" CssClass="form-control" required="true"></asp:TextBox>
        </div>
    </div>

    <div class="row text-center">
        <div class="col col-md-12">
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" CssClass="btn btn-success"/>
        </div>
    </div>

</asp:Content>
