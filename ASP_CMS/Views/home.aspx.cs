using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_CMS.Views.Layouts
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //int productId = int.Parse(Request.QueryString["id"]);
                SliderHome.DataSource = GetProduct();
                SliderHot.DataSource = GetHotWeek();
                SliderHome.DataBind();
                SliderHot.DataBind();
            }
            catch (Exception)
            {

            }

        }

        public System.Data.DataTable GetProduct()
        {

                var productos = Models.ConnectionClass.PortarDades(@"SELECT TOP 4 url
                                                                    FROM [dbo].[articulos]
																	join fotos_articulos on fotos_articulos.id_articulo = articulos.id
                                                                    join fotos on fotos.id = fotos_articulos.id_foto                                                              
                                                                    ORDER BY NEWID()");
                return productos.Tables["dades"];
            
     


        }

        public System.Data.DataTable GetHotWeek()
        {

            var productos = Models.ConnectionClass.PortarDades(@"SELECT TOP 7 *
                                                                    FROM [dbo].[articulos]
																	join fotos_articulos on fotos_articulos.id_articulo = articulos.id
                                                                    join fotos on fotos.id = fotos_articulos.id_foto                                                              
                                                                    ORDER BY NEWID()");
            return productos.Tables["dades"];




        }


    }
}