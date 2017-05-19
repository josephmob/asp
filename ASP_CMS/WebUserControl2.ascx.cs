using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_CMS
{
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {
        public int idCategoria
        {
            get
            {
                return this.idCategoria;
            }
            set
            {
                this.idCategoria = value;
            }
        }
    }
}