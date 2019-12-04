
using System;
using System.Web;
using System.Web.UI;
using System.Data;
using PaisesYPlatillos.Controllers;
using PaisesYPlatillos.Models;
using System.Web.UI.WebControls;

namespace PaisesYPlatillos
{
	public partial class Default2 : System.Web.UI.Page
	{
		private MoviesController mcontroller;

		//Eliminar pelicula
		protected void DeleteMovie_Click(object sender, EventArgs e)
		{
			this.mcontroller.DeleteMovie(Convert.ToInt32(this.movieId.Text));

			Response.Redirect("/Default2.aspx");
		}

		public Default2()
		{
			this.mcontroller = new MoviesController();

		}

		protected void Page_Load(object sender, EventArgs e)
		{
			this.Grid.DataSource = this.mcontroller.GetList();

			DataBind();
		}

		protected void AddMovie(object sender, EventArgs e)
		{
			this.mcontroller.AddMovie(new Movie(this.movieTitle.Text, this.movieGenre.Text));

			Response.Redirect("/Default2.aspx");
		}

		protected void DeleteItem(object sender, EventArgs e)
		{
			this.mcontroller.DeleteMovie(Convert.ToInt32(this.deleteMovie.Text));
			Response.Redirect("/Default2.aspx");//
		}

		protected void EditItem(object sender, EventArgs e)
		{
			// Hay que agregar otro formulario para editar
			int s = Convert.ToInt32(this.gmovieId.Text);
			this.mcontroller.EditMovie(new Movie(s, this.gmovieGenre.Text, this.gmovieTitle.Text));
			Response.Redirect("/Default2.aspx");//
		}


	}
}

