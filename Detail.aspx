<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="E_Commerce.Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" id="container" runat="server">

        <div class="row justify-content-center">
            <div class="col-8">
                <div class="card glass d-flex shadow-lg">
                    <div class="position-relative px-5">
                        <asp:Image ID="backgroundImage" runat="server" CssClass="card-img-top" />
                        <div>
                            <asp:Image ID="ImageCover" runat="server" CssClass="position-absolute bottom-0 start-0 w-25 rounded-1 shadow-lg" />
                        </div>
                    </div>
                    <div class="card-header text-center glass mt-3">
                        <asp:Label ID="title" runat="server" CssClass="fs-2 fw-bold"></asp:Label>
                    </div>
                    <div class="card-body">
                        <div class="px-5">
                            <span id="badge" runat="server"></span>
                            <p class="card-text border-bottom" id="year" runat="server"></p>
                            <p class="card-text border-bottom" id="director" runat="server"></p>
                            <p class="card-text border-bottom" id="production" runat="server"></p>
                            <p class="card-text border-bottom" id="firstActor" runat="server"></p>
                            <p class="card-text border-bottom" id="price" runat="server"></p>
                            <p class="card-text border-bottom" id="rating" runat="server"></p>
                            <p class="card-text border-bottom" id="duration" runat="server"></p>
                        </div>
                        <div class="px-5 text-center">
                            <h4 class="text-center glass mt-2">Immagini correlate</h4>
                            <asp:ImageButton ID="Image1" runat="server" OnClientClick="return false;" CssClass="w-25" data-bs-toggle="modal" data-bs-target="#exampleModal" data-bs-whatever="@mdo" />
                            <asp:ImageButton ID="Image2" runat="server" OnClientClick="return false;" CssClass="w-25" data-bs-toggle="modal" data-bs-target="#exampleModal2" data-bs-whatever="@mdo" />
                            <asp:ImageButton ID="Image3" runat="server" OnClientClick="return false;" CssClass="w-25" data-bs-toggle="modal" data-bs-target="#exampleModal3" data-bs-whatever="@mdo" />
                        </div>
                    </div>
                    <div class="card-footer text-body-secondary text-center py-5 d-flex justify-content-center gap-4">
                        <asp:DropDownList ID="language" runat="server" CssClass="glass text-light">
                            <asp:ListItem Value="Italiano" Text="Italiano" CssClass="glass text-light"></asp:ListItem> 
                            <asp:ListItem Value="English" Text="English" CssClass="glass text-light"></asp:ListItem> 
                            <asp:ListItem Value="German" Text="German" CssClass="glass text-light"></asp:ListItem> 
                            <asp:ListItem Value="Spanish" Text="Spanish" CssClass="glass text-light"></asp:ListItem> 
                            <asp:ListItem Value="French" Text="French" CssClass="glass text-light"></asp:ListItem> 
                        </asp:DropDownList>
                        <asp:Button ID="AddCart" runat="server" Text="Metti nel carrello" CssClass="btn bottone " OnClick="AddCart_Click" />
                    </div>
                </div>
            </div>
        </div>

        <div class="row justify-content-center mt-2">
            <div class="col-8">
                <div class="accordion" id="accordionExample">
                    <div class="accordion-item glass">
                        <h2 class="accordion-header">
                            <button class="accordion-button collapsed ancora m-0 text-light" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                Reviews
                            </button>
                        </h2>
                        <div id="collapseOne" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
                            <div class="accordion-body glass">
                                <asp:Label ID="noReviewsMessage" runat="server" Text="Non sono presenti Recensioni!"></asp:Label>
                                <asp:Repeater ID="reviewsRepeater" runat="server" ItemType="E_Commerce.Models.Review_User">
                                    <ItemTemplate>
                                        <div class="row d-flex align-items-center my-2 glass text-light">
                                            <div class="col-2 d-flex flex-column align-items-center p-1">
                                                <p class="fw-bold m-0"><%# Item.Username %></p>
                                                <img src="Content/assets/<%# Item.ProfileImg %>" alt ="<%# Item.Username %>Avatar" class="w-25 rounded-circle" />
                                            </div>
                                            <div class="col-9 mx-2 py-2 rounded-5">
                                                <p class="m-0">Review:</p>
                                                <p><%# Item.Text %></p>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>


                </div>
            </div>
        </div>
        <div class="row justify-content-center mt-2">
            <asp:Label ID="commentMessage" runat="server" Text="Effettua il Login per lasciare una Recensione" CssClass="alert alert-danger mx-auto text-center my-2 fw-bold w-50"></asp:Label>
                        <div class="col-8 glass p-3" id="commentContainer" runat="server">
                <asp:TextBox ID="CommentBox" runat="server" CssClass="form-control w-100"></asp:TextBox>
                <asp:Button ID="SendComment" runat="server" Text="Invia" CssClass="btn bottone w-100 my-4"  OnClick="SendComment_Click" />
            </div>
        </div>
    </div>
    <div class="modal fade glass" id="exampleModal" aria-labelledby="exampleModalLabel" aria-hidden="false">
        <div class="modal-dialog">
            <div class="modal-content bg-dark">
                <div class="modal-header">
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <asp:Image ID="ImageModal1" runat="server" CssClass="img-fluid" />

                </div>

            </div>
        </div>
    </div>
    <div class="modal fade glass" id="exampleModal2" aria-labelledby="exampleModal2Label" aria-hidden="false">
        <div class="modal-dialog">
            <div class="modal-content bg-dark">
                <div class="modal-header">
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <asp:Image ID="ImageModal2" runat="server" CssClass="img-fluid" />

                </div>

            </div>
        </div>
    </div>
    <div class="modal fade glass" id="exampleModal3" aria-labelledby="exampleModal3Label" aria-hidden="false">
        <div class="modal-dialog">
            <div class="modal-content bg-dark">
                <div class="modal-header">
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <asp:Image ID="ImageModaL3" runat="server" CssClass="img-fluid" />

                </div>

            </div>
        </div>
    </div>
</asp:Content>

