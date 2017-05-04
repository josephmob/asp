using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_CMS.Views.Layouts
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gridProductosCategoria.DataSource = GetCategoryProducts();
            gridProductosCategoria.DataBind();
        }
        public System.Data.DataTable GetCategoryProducts()
        {
            var productos = Models.ConnectionClass.PortarDades("select * from articulos");

            return productos.Tables["dades"];
        }
    }
}