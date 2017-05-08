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
            try
            {
                int categoryId = int.Parse(Request.QueryString["categoryId"]);
                gridProductosCategoria.DataSource = GetCategoryProducts(categoryId);
                gridProductosCategoria.DataBind();

                NombreCategoria.Text = GetCategoryName(categoryId);
                NombreCategoriaSiteMap.Text = GetCategoryName(categoryId);
            }
            catch (Exception)
            {

            }
            
        }
        public System.Data.DataTable GetCategoryProducts(int categoryId)
        {
            var productos = Models.ConnectionClass.PortarDades(@"select articulos.id id,articulos.nombre nombre, articulos.descripcion descripcion, articulos.precio precio, 
url = (Select top 1 fotos.url from fotos   
join fotos_articulos on fotos.id = fotos_articulos.id_foto
where fotos_articulos.id_articulo = articulos.id), 
categorias.nombre categoria, subcategorias.nombre subcategoria
from articulos
left join articulos_subcategorias on articulos_subcategorias.id_articulo = articulos.id
left join subcategorias on articulos_subcategorias.id_subcategoria = subcategorias.id
left join categorias on subcategorias.id_categoria = categorias.id
where categorias.id = " + categoryId);

            return productos.Tables["dades"];
        }
        public string GetCategoryName(int categoryId)
        {
            var categoria = Models.ConnectionClass.PortarDades(@"select *
from categorias
where categorias.id = " + categoryId);

            return categoria.Tables["dades"].Rows[0]["nombre"].ToString();
        }
    }
}