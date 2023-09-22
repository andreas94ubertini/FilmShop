<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="E_Commerce.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex flex-column align-items-center glass w-25 mx-auto pt-4 pb-3 rounded">
        <h3>Registrati!</h3>
        <label for="name" class="mt-2">Name:</label>
        <asp:TextBox ID="name" runat="server" CssClass="form-control w-75"></asp:TextBox>
        <label for="surname" class="mt-2">Surname:</label>
        <asp:TextBox ID="surname" runat="server" CssClass="form-control w-75"></asp:TextBox>
        <label for="username" class="mt-2">Username:</label>
        <asp:TextBox ID="username" runat="server" CssClass="form-control w-75"></asp:TextBox>
        <label for="password" class="mt-2">Password:</label>
        <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control w-75"></asp:TextBox>
        <asp:FileUpload ID="avatar" runat="server" CssClass="my-3 form-control w-75"/>
        <asp:Button ID="signInButton" runat="server" Text="Sign In" CssClass="btn bottone mb-4" OnClick="signInButton_Click"/>

        <div id="errorMessage" runat="server" class="alert alert-danger">
            <p>Username già utilizzato, cambialo!</p>
        </div>
    </div>
</asp:Content>
