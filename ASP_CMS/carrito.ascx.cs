using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_CMS
{

    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        private int _idArticulo;
        public int idArticulo
        {
            get
            {
                return _idArticulo;
            }
            set
            {
                _idArticulo = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void botoncarro_Click(object sender, EventArgs e)
        {
            var dt = new System.Data.DataSet();      /* GENERAMOS UN DATASET */
            int id = idArticulo;

            if (Session["dt"] == null)
            {
                
                DataTable datos = new DataTable(); /* GENERAMOS LA TABLA PARA EL DATASET */
                dt.Tables.Add(datos);              /* ASINGAMOS LA TABLA CREADA AL DATASET */
                datos.Columns.Add("id_articulo", typeof(Double));
                datos.Columns.Add("cantidad", typeof(Double));

                dt.Tables[0].Rows.Add(id, "1");

                Session["dt"] = dt;

            } else
            {
                dt = (System.Data.DataSet)Session["dt"];

                DataRow[]  articuloRow = dt.Tables[0].Select("id_articulo = " + id);
                int quants = articuloRow.Count();

                if (quants == 0)
                {
                    dt.Tables[0].Rows.Add(id, "1");
                } else
                {
                    articuloRow[0]["cantidad"] = (Double)articuloRow[0]["cantidad"] + 1;
                }
                
                

                Session["dt"] = dt;
            }
            
            
        }
    }
}