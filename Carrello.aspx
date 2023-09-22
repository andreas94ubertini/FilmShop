<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="E_Commerce.Carrello" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Repeater ID="Repeater1" runat="server" ItemType="E_Commerce.Models.Film">
            <ItemTemplate>
                <div class="row justify-content-center">
                    <div class="col-9">
                        <div class="card  glass mb-3">
                            <div class="row g-0">
                                <div class="col-2">
                                    <img src="../Content/assets/<%# Item.CoverImg %>" class="w-100 rounded-1" alt="cover" />
                                </div>
                                <div class="col-10 d-flex">
                                    <div class="card-body d-flex gap-3 align-items-center justify-content-between">
                                        <div>
                                            <h5 class="card-title"><%# Item.Title %></h5>
                                            <p class="card-text"><%# Item.Production %></p>
                                            <p class="card-text"><small class="Anno Produzione">Anno: <%# Item.Year %></small></p>
                                            <p class="card-text"><small>Lingua Selezionata: <%# Item.Language %></small></p>
                                            <p class="card-text"><small>Prezzo: <%# Item.Price %>€</small></p>
                                        </div>
                                        <div class="d-flex flex-column gap-2">
                                            <asp:Button ID="DeleteButton" CommandArgument="<%#Item.Id %>" runat="server" Text="Rimuovi dal carrello" CssClass="btn bottoneRed" OnClick="DeleteButton_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </ItemTemplate>
        </asp:Repeater>
        <div class="glass p-2 my-2">
            <h3 id="totale" runat="server" class="m-0"></h3>
        </div>
    </div>
    <div class="d-flex flex-column align-items-center glass">
        <asp:Label ID="message" runat="server" Text="Carrello Vuoto!" CssClass="fw-bold fs-2"></asp:Label>
        <asp:Button ID="SvuotaCarrello" runat="server" Text="Svuota Carrello" CssClass="btn ancoraRed" OnClick="SvuotaCarrello_Click" />
    </div>
</asp:Content>
