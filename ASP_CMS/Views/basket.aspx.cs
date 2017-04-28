using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP_CMS.Models;

namespace ASP_CMS.Views.Layouts
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lvProductos.DataSource = lvProductos_GetData();
            lvProductos.DataBind();
        }

        public System.Data.DataTable lvProductos_GetData()
        {
            var productos = Models.ConnectionClass.PortarDades("select * from articulos");


            return productos.Tables["dades"];
        }

    }
}