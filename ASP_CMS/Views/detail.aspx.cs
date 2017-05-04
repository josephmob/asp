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
            }
            catch (Exception)
            {
                
            }

        }
        public System.Data.DataTable GetProduct(int productId)
        {
            if (/*productId.HasValue &&*/ productId > 0)
            {
                var productos = Models.ConnectionClass.PortarDades("select * from articulos where id = " + productId);
                return productos.Tables["dades"];
            }
            else
            {
                return null;
            }


        }
    }
}