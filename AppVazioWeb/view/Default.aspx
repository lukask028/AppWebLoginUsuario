<%@ Page Title="Default" Language="C#" MasterPageFile="~/control/Page.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppVazioWeb.view.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <!-- Código -->

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <!-- Código -->
    Minha página Inicial do Projeto Criado

    <div class="container">
    <h1>Cadastrar - <asp:Label ID="lblMensagem" runat="server" Text="Resposta"></asp:Label></h1>
    <p>Digite Suas Informações.</p>
    <hr>

    <label for="email"><b>Email</b></label>    
        <asp:TextBox ID="txbEmail" placeholder="Digite seu e-mail" runat="server" />

    <label for="psw"><b>Senha</b></label>    
        <asp:TextBox ID="txbSenha" placeholder="Digite sua Senha" type="password" runat="server" />

    <label for="psw-repeat"><b>Confirmação da Senha</b></label>    
        <asp:TextBox ID="txbsenhaRepete" placeholder="Repita sua Senha"  type="password"  runat="server" />
    <hr>
        <asp:GridView ID="gdvExibir" runat="server"></asp:GridView> 
    <p>By creating an account you agree to our <a href="#">Terms & Privacy</a>.</p>

        <asp:Button ID="btnEnviar" class="registerbtn" Text="Salvar" runat="server" OnClick="btnEnviar_Click" />

        <asp:Button ID="btnIrLogin" class="registerbtn" Text="Ir para o Login" runat="server" OnClick="btnGoLogin_Click" />
  </div>

    
  
  <div class="container signin">
    <p>Already have an account? <a href="#">Sign in</a>.</p>
  </div>
    <!-- Fim Form-->


</asp:Content>
