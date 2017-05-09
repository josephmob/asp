using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using ASP_CMS.Models;

namespace ASP_CMS.Views.Layouts
{
    public partial class _Layout : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable dt = this.GetDataParent();
            cargarMenu(dt, 0, null);

        }

        private DataTable GetDataParent()
        {
            string query = "SELECT id, nombre as nombre FROM categorias";

            var categorias = Models.ConnectionClass.PortarDades(query);

            return categorias.Tables["dades"];

        }

        private DataTable GetDataChild(int parentMenuId)
        {
            string query = "SELECT id, nombre as nombre, id_categoria FROM subcategorias WHERE id_categoria = " + parentMenuId;

            var categorias = Models.ConnectionClass.PortarDades(query);

            return categorias.Tables["dades"];

        }

        private void cargarMenu(DataTable dt, int parentMenuId, MenuItem parentMenuItem)
        {
            string currentPage = Path.GetFileName(Request.Url.AbsolutePath);
            foreach (DataRow row in dt.Rows)
            {
                MenuItem menuItem = new MenuItem
                {
                    Value = row["id"].ToString(),
                    Text = row["nombre"].ToString(),
                    NavigateUrl = "category.aspx?categoryId=" + row["id"].ToString(),
                    Selected = row["nombre"].ToString().EndsWith(currentPage, StringComparison.CurrentCultureIgnoreCase)
                };
                if (parentMenuId == 0)
                {
                    MyMenu.Items.Add(menuItem);
                    DataTable dtChild = this.GetDataChild(int.Parse(menuItem.Value));
                    cargarMenu(dtChild, int.Parse(menuItem.Value), menuItem);
                }
                else
                {
                    parentMenuItem.ChildItems.Add(menuItem);
                }
            }
        }



    }



}