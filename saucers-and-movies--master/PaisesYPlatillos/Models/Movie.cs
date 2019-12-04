/*
 * Este archivo sirve para establecer el modelo de los objetos de peliculas.
*/

using System;

namespace PaisesYPlatillos.Models
{   
    public class Movie : GenericModel
    {
        public Movie() : base() //un constructor vacio
        {

        }
        public Movie(System.Web.UI.WebControls.TextBox movieID) : base() //un constructor vacio
        {

        }

        public Movie(int id) : base() //constructor para borrar
        {
            this.Id = id;
        }

        public Movie(string title, string genre): base() //constructor con 2 atributos
        {
            this.Title = title;
            this.Genre = genre;
        }

        public Movie(int id, string title, string genre): base(id) //constructor con 3 atributos 
        {
            // this.Id = id; Este se asigna desde "base()" llamando el contructor de la clase padre "Generic Model"
            this.Title = title;
            this.Genre = genre;
        }

        // Atributos de la clase
        // Getters y setters
        public string Title { get; set; }
        public string Genre { get; set; }
    }
}
