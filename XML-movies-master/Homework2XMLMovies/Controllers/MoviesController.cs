using System;
using System.Collections.Generic;
using Homework2XMLMovies.Models;
using System.Data;
using System.Xml;


namespace Homework2XMLMovies.Controllers

//Hacer las operaciones del Crud

{
    public class MoviesController
    {
        private readonly string FilePath = @"/Users/pamelaruizhernandez/Projects/Homework2XMLMovies/Homework2XMLMovies/data.xml";
        //filepath sera definido como la ruta de el archivo xml 
        public MoviesController()
        {
        }
        //______________________________________
        //metodo para leer xml
        private DataTable ReadData()
        {
            DataSet ds = new DataSet("Data");//transformar el archivo a objetos 
            ds.ReadXml(this.FilePath);//leemos el xml 
            return ds.Tables["peliculas"];//regresa la tabla que se llama peliculas 
        }
        //_______________________________________
        //transformar el archuvo xml a una lista de objetos  
            //generamos la lista que contendra las peliculas 
        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();
            DataTable xmlMovies = this.ReadData();//mandamos a llamar el metodo para leer el archivo
            foreach (DataRow row in xmlMovies.Rows)
            {
                Movie aux = new Movie(Int32.Parse(row["id"].ToString()), row["title"].ToString(), row["genre"].ToString());//convierte la tabla a cadena de texto 
                movies.Add(aux);// add añadir un elemento nuevo a la lista
            }

            return movies;
        }
        //_______________________________________
        public int CreateMovie(Movie item)
        {
            return this.WriteData(this.GetMovies(), item, true);//mandamos un objeto tipo movie que es item y la bandera que es true 
        }
        //_______________________________________
        public void DeleteMovie(int id)
        {
            int findIndex = 0;
            int i = 0;
            List<Movie> movies = this.GetMovies();//guardamos en la variable 
            foreach (Movie item in movies)//para usar solamente movies aqui 
            {
                if (item.Id == id)
                {
                    findIndex = i;//importa el lugar en la lista, para borrarlo, no el id en si 
                }
                i++;
            }
            movies.RemoveAt(findIndex);
            this.WriteData(movies, new Movie()); 
            // metodo valdepeña ReadData().Rows[findIndex].Delete();

        }
        //_______________________________________
        private int WriteData(List<Movie> currentMovies, Movie item, bool add = false)
        {
 
            XmlWriter writer = XmlWriter.Create(FilePath);
            // si no pongo new accedo como tal a un metodo estatico
            //creo una instancia con new
            //una instancia es diferente a un metodo estatico


            int lastID = 0;//suponiendo que el ultimo id es 0

            writer.WriteStartDocument();//indicar que comenzara a escribir el doc xml
            writer.WriteStartElement("data");//voy a crear un elemento en el xml la bd data

            foreach (Movie mv in currentMovies)
            {
                if (mv.Id > lastID)
                {
                    lastID = mv.Id;
                }
                writer.WriteStartElement("peliculas");
                writer.WriteElementString("id", mv.Id.ToString());
                writer.WriteElementString("title", mv.Title);
                writer.WriteElementString("genre", mv.Genre);
                writer.WriteEndElement();

            }
            lastID = lastID + 1;

            if (add)
            {
                writer.WriteStartElement("peliculas");
                writer.WriteElementString("id", lastID.ToString());
                writer.WriteElementString("title", item.Title);
                writer.WriteElementString("genre", item.Genre);
                writer.WriteEndElement();
            }
            else
            {
                lastID = 0;
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            return lastID;
        }
    }
}
