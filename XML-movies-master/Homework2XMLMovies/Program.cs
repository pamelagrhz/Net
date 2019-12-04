using System;
using System.Data;
using Homework2XMLMovies.Models;
using Homework2XMLMovies.Controllers;
using System.Collections.Generic;

using Homework2XMLMovies.Views;


namespace Homework2XMLMovies

{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MoviesView view = new MoviesView();
            bool repeat = true;
            Console.WriteLine("This program contains the CRUD(Create, Read, Update & Delete) of some Movies");
            Console.WriteLine("Catalogo de Peliculas:");

            do
            {

                Console.WriteLine("Elige una opcion:");
                int i = 0;//contador para las opciones
                int selected = 0;//opcion seleccionada
                DataSet dts = new DataSet("HW2DB");//nombre de la base
                Movie m = new Movie();


                string[] options = new string[]//asignamos las opciones
                {
                "Alta","Consulta","Baja","SALIR"
                };
                foreach (string opt in options)//ahora imprimimos las opciones
                {
                    Console.WriteLine((i + 1) + ") " + opt);
                    i++;
                };

                try//para tener una ecxepcion 
                {
                    selected = Convert.ToInt32(Console.ReadLine());//leer el seleccionado 

                    switch (selected)//que hacer con cada opción
                    {
                        case 1:
                            view.AddMovie();//agregar pelicula
                            break;
                        case 2:
                            view.DisplayMovies();//mostrar peliculas 
                            break;
                        case 3:
                            view.DeleteMovie();//Borrar pelicula
                            break;
                        case 4:
                            Console.WriteLine("BYE!");//salir
                            repeat = false;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion válida");//en caso de una opcion invalida
                            break;

                    }
                }
                catch (FormatException)// añadimos una excepcion 
                {
                    Console.WriteLine("error, elige una opcion numerica");
                }
            } while (repeat);//al terminar repite





        }
    }
}
