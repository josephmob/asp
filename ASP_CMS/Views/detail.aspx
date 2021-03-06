﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layouts/_Layout.Master" AutoEventWireup="true" CodeBehind="detail.aspx.cs" Inherits="ASP_CMS.Views.Layouts.WebForm3" %>
<%@ Register Src="~/carrito.ascx" TagPrefix="uc1" TagName="carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="all">

        <div id="content">
            <div class="container">

                <div class="col-md-12">
                    <ul class="breadcrumb">
                        <li><a href="#">Home</a>
                        </li>
                        <li><a href="#">Ladies</a>
                        </li>
                        <li>White Blouse Armani</li>
                    </ul>
                </div>

                <div class="col-md-3">
                    <!-- *** MENUS AND FILTERS ***
 _________________________________________________________ -->
                    <div class="panel panel-default sidebar-menu">

                        <div class="panel-heading">
                            <h3 class="panel-title">Categories</h3>
                        </div>

                        <div class="panel-body">
                            <ul class="nav nav-pills nav-stacked category-menu">
                                <li>
                                    <a href="#">
                                        <asp:Label ID="NombreCategoriaSideBar" runat="server" Text="Categoria No Encontrada"></asp:Label></a>
                                    <asp:ListView runat="server" ID="lvSubcategorias">
                                        <LayoutTemplate>
                                            <ul>
                                                <div runat="server" id="itemPlaceHolder" />
                                            </ul>
                                        </LayoutTemplate>
                                        <ItemTemplate>
                                            <li><a href="category.aspx?categoryId=<%# Eval("id") %>"><%# Eval("nombre") %> </a>
                                            </li>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </li>
                            </ul>

                        </div>
                    </div>

                    <!--  <div class="panel panel-default sidebar-menu">

                        <div class="panel-heading">
                            <h3 class="panel-title">Brands <a class="btn btn-xs btn-danger pull-right" href="#"><i class="fa fa-times-circle"></i> Clear</a></h3>
                        </div>

                        <div class="panel-body">

                            <form>
                                <div class="form-group">
                                    <div class="checkbox">
                                        <label>
                                            <input type="checkbox">Armani (10)
                                        </label>
                                    </div>
                                    <div class="checkbox">
                                        <label>
                                            <input type="checkbox">Versace (12)
                                        </label>
                                    </div>
                                    <div class="checkbox">
                                        <label>
                                            <input type="checkbox">Carlo Bruni (15)
                                        </label>
                                    </div>
                                    <div class="checkbox">
                                        <label>
                                            <input type="checkbox">Jack Honey (14)
                                        </label>
                                    </div>
                                </div>

                                <button class="btn btn-default btn-sm btn-primary"><i class="fa fa-pencil"></i> Apply</button>

                            </form>

                        </div>
                    </div>

                    <div class="panel panel-default sidebar-menu">

                        <div class="panel-heading">
                            <h3 class="panel-title">Colours <a class="btn btn-xs btn-danger pull-right" href="#"><i class="fa fa-times-circle"></i> Clear</a></h3>
                        </div>

                        <div class="panel-body">

                            <form>
                                <div class="form-group">
                                    <div class="checkbox">
                                        <label>
                                            <input type="checkbox"> <span class="colour white"></span> White (14)
                                        </label>
                                    </div>
                                    <div class="checkbox">
                                        <label>
                                            <input type="checkbox"> <span class="colour blue"></span> Blue (10)
                                        </label>
                                    </div>
                                    <div class="checkbox">
                                        <label>
                                            <input type="checkbox"> <span class="colour green"></span> Green (20)
                                        </label>
                                    </div>
                                    <div class="checkbox">
                                        <label>
                                            <input type="checkbox"> <span class="colour yellow"></span> Yellow (13)
                                        </label>
                                    </div>
                                    <div class="checkbox">
                                        <label>
                                            <input type="checkbox"> <span class="colour red"></span> Red (10)
                                        </label>
                                    </div>
                                </div>

                                <button class="btn btn-default btn-sm btn-primary"><i class="fa fa-pencil"></i> Apply</button>

                            </form>

                        </div>
                    </div>-->

                    <!-- *** MENUS AND FILTERS END *** -->

                    <div class="banner">
                        <a href="#">
                            <img src="/img/banner.jpg" alt="sales 2014" class="img-responsive">
                        </a>
                    </div>
                </div>

                <div class="col-md-9">

                    <asp:FormView ID="Producto" runat="server">
                        <ItemTemplate>
                            <div class="row" id="productMain">
                                <div class="col-sm-6">
                                    <div id="mainImage">
                                        <img src="/Upload/<%# Eval("url") %>" alt="" class="img-responsive">
                                    </div>
                                </div>
                                <div class="col-sm-6">
                                    <div class="box">
                                        <h1 class="text-center"><%# Eval("nombre") %></h1>
                                        <p class="goToDescription">
                                            <a href="#details" class="scroll-to">Scroll hasta detalles del producto, material &amp; y tallas</a>
                                        </p>
                                        <p class="price"><%# Eval("precio") %>€</p>

                                        <p class="text-center buttons">
                                            <uc1:carrito runat="server" ID="carrito" idArticulo='<%# Eval("id") %>' />
                                        </p>
                                    </div>

                                    <%--<div class="row" id="thumbs">
                                        <div class="col-xs-4">
                                            <a href="/img/detailbig1.jpg" class="thumb">
                                                <img src="/img/detailsquare.jpg" alt="" class="img-responsive">
                                            </a>
                                        </div>
                                        <div class="col-xs-4">
                                            <a href="/img/detailbig2.jpg" class="thumb">
                                                <img src="/img/detailsquare2.jpg" alt="" class="img-responsive">
                                            </a>
                                        </div>
                                        <div class="col-xs-4">
                                            <a href="/img/detailbig3.jpg" class="thumb active">
                                                <img src="/img/detailsquare3.jpg" alt="" class="img-responsive">
                                            </a>
                                        </div>
                                    </div>--%>
                                </div>
                            </div>


                            <div class="box" id="details">
                                <p>
                                </p>
                                <h4>Detalles del producto</h4>
                                <p><%# Eval("descripcion") %></p>
                                <%--<h4>Material &amp; care</h4>
                                <ul>
                                    <li>Polyester</li>
                                    <li>Machine wash</li>
                                </ul>
                                <h4>Size &amp; Fit</h4>
                                <ul>
                                    <li>Regular fit</li>
                                    <li>The model (height 5'8" and chest 33") is wearing a size S</li>
                                </ul>

                                <blockquote>
                                    <p>
                                        <em>Define style this season with Armani's new range of trendy tops, crafted with intricate details. Create a chic statement look by teaming this lace number with skinny jeans and pumps.</em>
                                    </p>
                                </blockquote>

                                <hr>
                                <div class="social">
                                    <h4>Show it to your friends</h4>
                                    <p>
                                        <a href="#" class="external facebook" data-animate-hover="pulse"><i class="fa fa-facebook"></i></a>
                                        <a href="#" class="external gplus" data-animate-hover="pulse"><i class="fa fa-google-plus"></i></a>
                                        <a href="#" class="external twitter" data-animate-hover="pulse"><i class="fa fa-twitter"></i></a>
                                        <a href="#" class="email" data-animate-hover="pulse"><i class="fa fa-envelope"></i></a>
                                    </p>
                                </div>--%>
                            </div>
                        </ItemTemplate>
                    </asp:FormView>

                    <div class="row same-height-row">

                        <div class="col-md-3 col-sm-6">
                            <div class="box same-height" style="height: 379px;">
                                <h3>Mas venidas</h3>
                            </div>
                        </div>

                        <asp:ListView ID="Ventas" runat="server">

                            <LayoutTemplate>
                                <div runat="server" id="itemPlaceHolder" />
                            </LayoutTemplate>

                            <ItemTemplate>
                                <div class="col-md-3 col-sm-6">
                                    <div class="product same-height" style="height: 379px;">
                                        <div class="flip-container">
                                            <div class="flipper">
                                                <div class="front">
                                                    <a href="detail.aspx?id=<%# Eval("id") %>">
                                                        <img src="/Upload/<%# Eval("url") %>" alt="" class="img-responsive">
                                                    </a>
                                                </div>
                                                <div class="back">
                                                    <a href="detail.aspx?id=<%# Eval("id") %>">
                                                        <img src="/Upload/<%# Eval("url") %>" alt="" class="img-responsive">
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                        <a href="detail.aspx?id=<%# Eval("id") %>" class="invisible">
                                            <img src="/Upload/<%# Eval("url") %>" alt="" class="img-responsive">
                                        </a>
                                        <div class="text">
                                            <h3><%# Eval("nombre") %></h3>
                                            <p class="price"><%# Eval("precio") %> €</p>
                                        </div>
                                    </div>
                                    <!-- /.product -->
                                </div>

                            </ItemTemplate>
                        </asp:ListView>
                    </div>
    <!-- /.col-md-9 -->
            </div>
            <!-- /.container -->
        </div>
        <!-- /#content -->
</asp:Content>
