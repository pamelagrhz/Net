using System;
namespace Homework2XMLMovies.Models
{   //Este archivo sirve para establecer el modelo de los objetos de peliculas
    //tiene todos los constructores
    public class Movie
    {
        //aqui definiremos la tabla de modelos 
        private int id;
        private string title;
        private string genre;


        public Movie()//un constructor vacio
        {

        }

        public Movie(string title, string genre)//constructor con 2 atributos
        {
            this.Title = title;
            this.Genre = genre;
        }

        public Movie(int id, string title, string genre)//constructor con 3 atributos 
        {
            this.Id = id;//hacer referencia en una instancia a la misma clase this
            this.Title = title;
            this.Genre = genre;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }
    }
}
