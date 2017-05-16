<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layouts/_Layout.Master" AutoEventWireup="true" CodeBehind="basket.aspx.cs" Inherits="ASP_CMS.Views.Layouts.WebForm4" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="all">

        <div id="content">
            <div class="container">

                <div class="col-md-12">
                    <ul class="breadcrumb">
                        <li><a href="home.aspx">Home</a>
                        </li>
                        <li>Shopping cart</li>
                    </ul>
                </div>

                <div class="col-md-9" id="basket">

                    <div class="box">

                        <form method="post" action="checkout1.html">

                            <h1>Shopping cart</h1>
                            <p class="text-muted">You currently have this item(s) in your cart:</p>
                            <div class="table-responsive">
                                <table class="table">
                                    <thead>
                                        <tr>
                                            <th colspan="2">Product</th>
                                            <th>Cantidad</th>
                                            <th>Precio unitario</th>
                                            <th>IVA</th>
                                            <th colspan="2">Base imponible</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:ListView runat="server" ID="lvProductos">


                                            <LayoutTemplate>


                                                <div runat="server" id="itemPlaceHolder" />

                                            </LayoutTemplate>
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <a href="#">
                                                            <img src="/Upload/<%# Eval("url") %>" alt="White Blouse Armani">
                                                        </a>
                                                    </td>
                                                    <td><a href="#"><%# Eval("nombre") %></a>
                                                    </td>
                                                    <td>
                                                        <input type="number" value='<%# Eval("cantidad") %>' class="form-control">
                                                    </td>
                                                    <td><%# Eval("precio") %>€</td>
                                                    <td>21%</td>
                                                    <td>€</td>
                                                    <td><a href="#"><i class="fa fa-trash-o"></i></a>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </tbody>
                                    <tfoot>
                                        <tr>
                                            <th colspan="5">Total</th>
                                            <th colspan="2">
                                                <asp:Label Text="0" ID="PrecioTotal" runat="server" />€</th>
                                        </tr>
                                    </tfoot>
                                </table>

                            </div>
                            <!-- /.table-responsive -->

                            <div class="box-footer">
                                <div class="pull-left">
                                    <a href="category.html" class="btn btn-default"><i class="fa fa-chevron-left"></i>Continue shopping</a>
                                </div>
                                <div class="pull-right">
                                    <button class="btn btn-default"><i class="fa fa-refresh"></i>Update basket</button>
                                    <button type="submit" class="btn btn-primary">
                                        Proceed to checkout <i class="fa fa-chevron-right"></i>
                                    </button>
                                </div>
                            </div>

                        </form>

                    </div>
                    <!-- /.box -->


                    


                </div>
                <!-- /.col-md-9 -->

                <div class="col-md-3">
                    <div class="box" id="order-summary">
                        <div class="box-header">
                            <h3>Resumen de pedido</h3>
                        </div>
                        <p class="text-muted">Los precios de envío y transporte se calculan dependiendo del peso y tamaño de los elementos incluidos en el carrito</p>

                        <div class="table-responsive">
                            <table class="table">
                                <tbody>
                                    <tr>
                                        <td>Subtotal del pedido</td>
                                        <th><asp:Label Text="0" ID="orderSubtotal" runat="server" />€</th>
                                    </tr>
                                    <tr>
                                        <td>Envío</td>
                                        <th>10€</th>
                                    </tr>
                                    <tr>
                                        <td>Impuestos</td>
                                        <th><asp:Label Text="0" ID="orderAllTaxes" runat="server" />€</th>
                                    </tr>
                                    <tr class="total">
                                        <td>Total</td>
                                        <th><asp:Label Text="0" ID="orderFinalPrice" runat="server" />€</th>
                                    </tr>
                                </tbody>
                            </table>
                        </div>

                    </div>


                    <!--  <div class="box">
                        <div class="box-header">
                            <h4>Coupon code</h4>
                        </div>
                        <p class="text-muted">If you have a coupon code, please enter it in the box below.</p>
                        <form>
                            <div class="input-group">

                                <input type="text" class="form-control">

                                <span class="input-group-btn">

					<button class="btn btn-primary" type="button"><i class="fa fa-gift"></i></button>

				    </span>
                            </div>
                        </form>
                    </div>-->

                </div>
                <!-- /.col-md-3 -->

            </div>
            <!-- /.container -->
        </div>
        <!-- /#content -->
</asp:Content>
