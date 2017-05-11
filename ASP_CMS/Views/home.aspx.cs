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

                var productos = Models.ConnectionClass.PortarDades(@"select top 4 articulos.id id,articulos.nombre nombre, articulos.descripcion descripcion, articulos.precio precio, 
                url = (Select top 1 fotos.url from fotos   
                join fotos_articulos on fotos.id = fotos_articulos.id_foto
                where fotos_articulos.id_articulo = articulos.id), 
                categorias.nombre categoria, subcategorias.nombre subcategoria
                from articulos
                left join articulos_subcategorias on articulos_subcategorias.id_articulo = articulos.id
                left join subcategorias on articulos_subcategorias.id_subcategoria = subcategorias.id
                left join categorias on subcategorias.id_categoria = categorias.id                                                              
                ORDER BY NEWID()");
                return productos.Tables["dades"];
            
     


        }

        public System.Data.DataTable GetHotWeek()
        {

            var productos = Models.ConnectionClass.PortarDades(@"select top 7 articulos.id id,articulos.nombre nombre, articulos.descripcion descripcion, articulos.precio precio, 
                url = (Select top 1 fotos.url from fotos   
                join fotos_articulos on fotos.id = fotos_articulos.id_foto
                where fotos_articulos.id_articulo = articulos.id), 
                categorias.nombre categoria, subcategorias.nombre subcategoria
                from articulos
                left join articulos_subcategorias on articulos_subcategorias.id_articulo = articulos.id
                left join subcategorias on articulos_subcategorias.id_subcategoria = subcategorias.id
                left join categorias on subcategorias.id_categoria = categorias.id                                                              
                ORDER BY NEWID()");
            return productos.Tables["dades"];




        }


    }
}