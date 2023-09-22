<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="E_Commerce.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex flex-column align-items-center glass w-25 mx-auto pt-4 pb-3 rounded">
        <h3>Effettua l'accesso!</h3>
        <label for="username" class="mt-2">Username:</label>
        <asp:TextBox ID="username" runat="server" CssClass="form-control w-75"></asp:TextBox>
        <label for="password" class="mt-2">Password:</label>
        <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="mb-2 form-control w-75"></asp:TextBox>
        <asp:Button ID="loginButton" runat="server" Text="Login" CssClass="btn bottone mb-4" OnClick="loginButton_Click" />

        <div id="errorMessage" runat="server" class="alert alert-danger">
            <p>Dati non validi! Riprova</p>
        </div>
    </div>
</asp:Content>
