using System.Web.UI.WebControls;

namespace subMenuItem
{
    public class subMenuItem : ListView
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