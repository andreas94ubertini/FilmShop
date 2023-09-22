<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_Commerce.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h3 class="fw-bold text-white text-center glass" id="title" runat="server">Interstellar</h3>
        <div class="d-flex justify-content-center preview-container position-relative w-100">
            <video autoplay muted id="video" runat="server" class="w-100" controls>
                <source src="Content/assets/interstellar.mp4" />
            </video>
        </div>


        <div class="accordion m-3" id="accordionExample">
            <div class="accordion-item glass">
                <h2 class="accordion-header">
                    <button class="accordion-button ancora collapsed fs-3 m-0" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="false" aria-controls="collapseOne">
                        Azione
                    </button>
                </h2>
                <div id="collapseOne" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
                    <div class="accordion-body glass">
                        <div class="row row-cols-3 row-cols-lg-4 justify-content-center glass">
                            <asp:Repeater ID="RepeaterAzione" runat="server" ItemType="E_Commerce.Models.Film">
                                <ItemTemplate>
                                    <div>
                                        <div class="card text-bg-secondary m-3">
                                            <a href="Detail.aspx?idFilm=<%# Item.Id %>">
                                                <img src="Content/assets/<%# Item.CoverImg %>" class="card-img-top rounded-2" alt="<%# Item.Title %>">
                                            </a>

                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
            <div class="accordion-item glass">
                <h2 class="accordion-header">
                    <button class="accordion-button ancora fs-3 collapsed m-0" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                        Fantascienza
                    </button>
                </h2>
                <div id="collapseTwo" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
                    <div class="accordion-body glass">
                        <div class="row row-cols-3 row-cols-lg-4 justify-content-center glass">
                            <asp:Repeater ID="RepeaterFantascienza" runat="server" ItemType="E_Commerce.Models.Film">
                                <ItemTemplate>
                                    <div>
                                        <div class="card text-bg-secondary m-3" style="width: 18rem;">
                                            <a href="Detail.aspx?idFilm=<%# Item.Id %>">
                                                <img src="Content/assets/<%# Item.CoverImg %>" class="card-img-top" alt="<%# Item.Title %>">
                                            </a>

                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
            <div class="accordion-item glass">
                <h2 class="accordion-header">
                    <button class="accordion-button collapsed ancora fs-3 m-0" type="button" data-bs-toggle="collapse" data-bs-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                        Horror
                    </button>
                </h2>
                <div id="collapseThree" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
                    <div class="accordion-body glass">
                        <div class="row row-cols-3 row-cols-lg-4 justify-content-center glass">
                            <asp:Repeater ID="RepeaterHorror" runat="server" ItemType="E_Commerce.Models.Film">
                                <ItemTemplate>
                                    <div>
                                        <div class="card text-bg-secondary m-3" style="width: 18rem;">
                                            <a href="Detail.aspx?idFilm=<%# Item.Id %>">
                                                <img src="Content/assets/<%# Item.CoverImg %>" class="card-img-top" alt="<%# Item.Title %>">
                                            </a>

                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
            <div class="accordion-item glass">
                <h2 class="accordion-header">
                    <button class="accordion-button ancora collapsed fs-3 m-0" type="button" data-bs-toggle="collapse" data-bs-target="#collapseFour" aria-expanded="false" aria-controls="collapseFour">
                        Fantasy
                    </button>
                </h2>
                <div id="collapseFour" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
                    <div class="accordion-body glass">
                        <div class="row row-cols-3 row-cols-lg-4 justify-content-center glass">
                            <asp:Repeater ID="RepeaterFantasy" runat="server" ItemType="E_Commerce.Models.Film">
                                <ItemTemplate>
                                    <div>
                                        <div class="card text-bg-secondary m-3" style="width: 18rem;">
                                            <a href="Detail.aspx?idFilm=<%# Item.Id %>">
                                                <img src="Content/assets/<%# Item.CoverImg %>" class="card-img-top" alt="<%# Item.Title %>">
                                            </a>

                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
            <div class="accordion-item glass">
                <h2 class="accordion-header">
                    <button class="accordion-button collapsed ancora fs-3 m-0" type="button" data-bs-toggle="collapse" data-bs-target="#collapseFive" aria-expanded="false" aria-controls="collapseFive">
                        Commedia
                    </button>
                </h2>
                <div id="collapseFive" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
                    <div class="accordion-body glass">
                        <div class="row row-cols-3 row-cols-lg-4 justify-content-center glass">
                            <asp:Repeater ID="RepeaterCommedia" runat="server" ItemType="E_Commerce.Models.Film">
                                <ItemTemplate>
                                    <div>
                                        <div class="card text-bg-secondary m-3" style="width: 18rem;">
                                            <a href="Detail.aspx?idFilm=<%# Item.Id %>">
                                                <img src="Content/assets/<%# Item.CoverImg %>" class="card-img-top" alt="<%# Item.Title %>">
                                            </a>

                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <a href="#topPage" class="topArrow"><i class="fa-solid fa-arrow-up"></i></a>
</asp:Content>
