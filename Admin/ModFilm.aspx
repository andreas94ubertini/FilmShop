<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModFilm.aspx.cs" Inherits="E_Commerce.Admin.ModFilm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row glass">
            <div class="col-12 text-center">
                <h2 id="header" runat="server"></h2>
                <div id="alert" runat="server" class="alert alert-success alert-dismissible fade show mt-5" role="alert">
                    <strong>Ottimo!</strong> Film Modificato con successo
                        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close" runat="server" id="btn"></button>
                </div>
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
                <p class="h5 m-0">Immagine Background</p>
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
                <asp:Button ID="ModifyButton" runat="server" Text="Modifica" CssClass="btn bottone my-5 w-50" OnClick="ModifyButton_Click" />
                <asp:Button ID="InsertButton" runat="server" Text="Inserisci" CssClass="btn bottone my-5 w-50" OnClick="InsertButton_Click" />
            </div>

        </div>
    </div>

    <script src="../Scripts/bootstrap.bundle.min.js"></script>
</asp:Content>
