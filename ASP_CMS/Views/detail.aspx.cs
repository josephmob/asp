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

                lvSubcategorias.DataSource = this.cargarsubcategorias(productId);
                lvSubcategorias.DataBind();
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
        public System.Data.DataTable cargarsubcategorias(int productId)
        {
            var categoria = Models.ConnectionClass.PortarDades(@"select categorias.id, categorias.nombre,subcategorias.id idSubCategoria
                from categorias, subcategorias, articulos_subcategorias
                where categorias.id = subcategorias.id_categoria
                and subcategorias.id = articulos_subcategorias.id_subcategoria
                and articulos_subcategorias.id_articulo = " + productId);
            var categoriaId = categoria.Tables["dades"].Rows[0]["id"].ToString();
            NombreCategoriaSideBar.Text = categoria.Tables["dades"].Rows[0]["nombre"].ToString();
            var subcategorias = Models.ConnectionClass.PortarDades("select * from subcategorias where id_categoria = " + categoriaId);

            return subcategorias.Tables["dades"];
        }
    }
}