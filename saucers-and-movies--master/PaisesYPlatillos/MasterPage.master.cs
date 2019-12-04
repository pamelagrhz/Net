using System;
using System.Web;
using System.Web.UI;
namespace PaisesYPlatillos
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {

        public void LBComida(object sender, EventArgs e)
        {
            Response.Redirect("/");
        }

        public void LBPeliculas(object sender, EventArgs e)
        {
            Response.Redirect("/Default2.aspx");
        }
    }
}
