<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="E_Commerce.Admin.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <asp:Repeater ID="Repeater1" runat="server" ItemType="E_Commerce.Models.Film">
            <ItemTemplate>
                <div class="row justify-content-center">
                    <div class="col-9">
                        <div class="card glass mb-3">
                            <div class="row g-0 glass">
                                <div class="col-2">
                                    <img src="../Content/assets/<%# Item.CoverImg %>" class="w-100 rounded-1" alt="cover" />
                                </div>
                                <div class="col-10 d-flex">
                                    <div class="card-body text-light d-flex gap-3 align-items-center justify-content-between">
                                        <div>
                                            <h5 class="card-title"><%# Item.Title %></h5>
                                            <p class="card-text"><%# Item.Production %></p>
                                            <p class="card-text"><small class="Anno Produzione"><%# Item.Year %></small></p>
                                        </div>
                                        <div class="d-flex flex-column gap-2">
                                            <a href="ModFilm.aspx?id=<%#Item.Id %>" class="btn ancoraYel">Modifica</a>
                                            <asp:Button ID="DeleteButton" CommandArgument="<%#Item.Id %>" runat="server" Text="Elimina" CssClass="btn ancoraRed" OnClick="DeleteButton_Click"/>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </ItemTemplate>
        </asp:Repeater>
    </div>
    <script src="../Scripts/bootstrap.bundle.min.js"></script>

</asp:Content>
