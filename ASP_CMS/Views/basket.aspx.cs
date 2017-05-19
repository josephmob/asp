using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP_CMS.Models;
using System.Data;

namespace ASP_CMS.Views.Layouts
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private double precioTotalCarrito = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lvProductos.DataSource = lvProductos_GetData();
                lvProductos.DataBind();
                getTotalPrice();
                PrecioTotal.Text = precioTotalCarrito.ToString();
                orderSubtotal.Text = precioTotalCarrito.ToString();
                orderAllTaxes.Text = ((precioTotalCarrito + 10) * 0.21).ToString();
                orderFinalPrice.Text = ((precioTotalCarrito + 10) * 1.21).ToString();
            }
            catch (Exception)
            {

            }

        }

        public System.Data.DataTable lvProductos_GetData()
        {
            var venta = Models.ConnectionClass.PortarDades("select *,'url' url from ventas WHERE 1=2");

            var compra = new System.Data.DataSet();
            compra = (System.Data.DataSet)Session["dt"];

            foreach (DataRow row in compra.Tables[0].Rows)
            {
                var articulo = Models.ConnectionClass.PortarDades("select articulos.nombre nombre, articulos.id id, articulos.precio precio, fotos.url url from articulos,fotos_articulos,fotos where articulos.id=fotos_articulos.id_articulo and fotos_articulos.id_foto = fotos.id and articulos.id = " + row["id_articulo"]);

                DataRow row2 = articulo.Tables[0].Rows[0];

                venta.Tables[0].Rows.Add(0, row["cantidad"], row["id_articulo"], row2["nombre"].ToString(), row2["precio"], row2["url"]);

            }

            //System.Data.DataTable act = Models.ConnectionClass.updateDT("select * from ventas where 1=2", venta);

            return venta.Tables[0];
        }

        public void getTotalPrice()
        {

            var compra = (System.Data.DataSet)Session["dt"];
            foreach (DataRow row in compra.Tables[0].Rows)
            {
                var articulo = Models.ConnectionClass.PortarDades("select * from articulos where id = " + row["id_articulo"]);
                precioTotalCarrito = precioTotalCarrito + ((double)articulo.Tables[0].Rows[0]["precio"] * (double)row["cantidad"]);
            }
            //return precioTotalCarrito.ToString();
        }

    }
}