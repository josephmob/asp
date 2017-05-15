using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

namespace ASP_CMS.Views.Layouts
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(Request.QueryString["id"]);
                Producto.DataSource = GetProduct(productId);
                Producto.DataBind();
              //  Venuts.DataSource = MesVenuts();
              //  Venuts.DataBind();
            }
            catch (Exception)
            {

            }

        }
        public System.Data.DataTable GetProduct(int productId)
        {
            if (/*productId.HasValue &&*/ productId > 0)
            {
                var productos = Models.ConnectionClass.PortarDades(@"select * 
                                                                    from articulos, fotos_articulos, fotos
                                                                    where articulos.id = fotos_articulos.id_articulo
                                                                    and fotos_articulos.id_foto = fotos.id
                                                                    and articulos.id = " + productId);
                return productos.Tables["dades"];
            }
            else
            {
                return null;
            }


        }


        public System.Data.DataTable MesVenuts() 
        {

            var productos = Models.ConnectionClass.PortarDades(@"SELECT TOP 3 *
                                                                    FROM [dbo].[articulos]
																	join fotos_articulos on fotos_articulos.id_articulo = articulos.id
                                                                    join fotos on fotos.id = fotos_articulos.id_foto                                                              
                                                                    ORDER BY NEWID()");
            return productos.Tables["dades"];




        }

    }
}