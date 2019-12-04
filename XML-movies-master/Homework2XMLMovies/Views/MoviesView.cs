using System;
using System.Collections.Generic;
using Homework2XMLMovies.Controllers;
using Homework2XMLMovies.Models;

namespace Homework2XMLMovies.Views
{
    public class MoviesView
    {
        MoviesController controller;

        //_______________________________________
        public MoviesView()
        {
            this.controller = new MoviesController();

        }
        //_______________________________________
        public void DisplayMovies()
        {
            List<Movie> movies = this.controller.GetMovies();// de la lista con peliculas y el controller
            //en getMovies en moviescontroller asignamos las peliculas como movie

            foreach (Movie item in movies)// imprimir las pelocilas
            {
                Console.WriteLine("__________________________");
                Console.WriteLine("    ID | " + item.Id.ToString());
                Console.WriteLine("Titulo |" + item.Title);
                Console.WriteLine("Genero | " + item.Genre);
                Console.WriteLine("__________________________");
                Console.WriteLine("");

            }

        }
        //_______________________________________
        public void AddMovie()
        {
            string title;
            string genre;
            Console.WriteLine("Agregar nueva película al catalogo:");
            Console.WriteLine("Ingresa el Título: ");
            title = Console.ReadLine();//obtenemos el titulo
            Console.WriteLine("Ingresa el Género: ");
            genre = Console.ReadLine();//obtenemos el genero 
            Movie item = new Movie(title,genre);//en movie generamos otra pelicula con titulo y genero 

            int generatedId =this.controller.CreateMovie(item);//ahora generaremos un id en create movie en 
            // movies controller 

            Console.WriteLine("Pelicula Agregada Exitosamente. ID: " + generatedId);//y lo usamos para imprimir en pantalla
        }
        //_______________________________________
        public void DeleteMovie()
        {
            int deleteId = 0;//es el Id que eliminaremos 
            Console.WriteLine("Eliminar pelicula del catálogo:");
            this.DisplayMovies();//llamamos este metodo para mostrar las peliculas
            Console.WriteLine("Ingresa el Id de la pelicula que deseas eliminar");
            deleteId = Convert.ToInt32(Console.ReadLine());//el id lo tomamos del usuario 

            this.controller.DeleteMovie(deleteId);//borrar la pelicula del usuario  con el id que nos dieron 
            Console.WriteLine("Pelicula de ID:" + deleteId + " eliminada correctamente");//mostramos un mensaje de que la operacion fu excitosa 

        }
    }

}
