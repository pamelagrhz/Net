using System;
using System.Web;
using System.Web.UI;
using System.Data;
using PaisesYPlatillos.Controllers;
using PaisesYPlatillos.Models;
using System.Web.UI.WebControls;

namespace PaisesYPlatillos
{
    public partial class Default : System.Web.UI.Page
    {
        private CountriesController controller;
        private SaucersController saucersController;

        // llamar a countries y saucers controller    
        public Default()
        {
            this.controller = new CountriesController();
            this.saucersController = new SaucersController();
        }
        //Cuando se lea la pagina
        protected void Page_Load(object sender, EventArgs e)
        {
            //mandamos a llamar el grid
            this.Grid.DataSource = this.saucersController.GetList();

           
            DataBind();//

            int i = 0;
            foreach (Country c in this.controller.GetList())
            {
                this.cboPais.Items.Add(c.Name);
                this.cboPais.Items[i].Text = c.Name;
                this.cboPais.Items[i].Value = c.Id.ToString();
                 this.cbaPais.Items.Add(c.Name);
                this.cbaPais.Items [i].Text = c.Name;
                this.cbaPais.Items [i].Value = c.Id.ToString();
                i++;
            }
		
          
        }

        //Agregar un platillo
        protected void AddSaucer(object sender, EventArgs e)
        {

            int countryId = Convert.ToInt32(this.cboPais.SelectedItem.Value);
            string saucersName = this.txtComida.Text;

            this.saucersController.AddSaucer(new Saucer(saucersName, countryId));

            Response.Redirect("/Default.aspx");//regargar la pagina
        }

        protected void DeleteSaucer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.saucerId.Text);

            this.saucersController.DeleteSaucer(id);
        }
		protected void EditItem(object sender, EventArgs e)
		{
			int counId = Convert.ToInt32(this.cbaPais.SelectedItem.Value);

			int m = Convert.ToInt32(this.eSaucerId.Text);
			this.saucersController.EditSaucer(new Saucer(m, this.eSaucerName.Text,counId));
			Response.Redirect("/Default.aspx");//
		}

    }
}


