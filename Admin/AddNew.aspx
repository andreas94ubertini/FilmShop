<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddNew.aspx.cs" Inherits="E_Commerce.Admin.AddNew" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-12 text-center">
                <h2>Inserisci un nuovo Film</h2>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Titolo</p>
                <asp:TextBox ID="TitleBox" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Regista</p>
                <asp:TextBox ID="DirectorBox" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Prezzo</p>
                <asp:TextBox ID="PriceBox" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Categoria</p>
                <asp:TextBox ID="CategoryBox" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Durata</p>
                <asp:TextBox ID="DurationBox" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Produzione</p>
                <asp:TextBox ID="ProductionBox" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Protagonista</p>
                <asp:TextBox ID="FirstActorBox" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Anno</p>
                <asp:TextBox ID="YearBox" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Rating</p>
                <asp:TextBox ID="RatingBox" runat="server" CssClass="form-control w-50"></asp:TextBox>
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Immagine Backgorund</p>
                <asp:FileUpload ID="BackgroundUpload" runat="server" CssClass="form-control" />
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Immagine Copertina</p>
                <asp:FileUpload ID="CoverImgUpload" runat="server" CssClass="form-control" />
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Immagine 1</p>
                <asp:FileUpload ID="Img1Upload" runat="server" CssClass="form-control" />
            </div>
            <div class="col-12 mt-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Immagine 2</p>
                <asp:FileUpload ID="Img2Upload" runat="server" CssClass="form-control" />
            </div>
            <div class="col-12 my-5 d-flex flex-column align-items-center">
                <p class="h5 m-0">Immagine 3</p>
                <asp:FileUpload ID="Img3Upload" runat="server" CssClass="form-control" />
            </div>
            <div class="col-12 d-flex justify-content-center">
                <asp:Button ID="InsertButton" runat="server" Text="Inserisci" CssClass="btn btn-outline-success my-5 w-50" OnClick="InsertButton_Click"/>
            </div>

        </div>
    </div>
</asp:Content>
