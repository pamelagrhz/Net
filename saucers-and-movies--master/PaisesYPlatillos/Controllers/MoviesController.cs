using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using PaisesYPlatillos.Models;


namespace PaisesYPlatillos.Controllers
{
    public class MoviesController : Controller
    {

        public MoviesController() : base("movies.xml", "movies")
        {

        }

        public List<Movie> GetList()//get list sin atributos
        {
            List<Movie> list = new List<Movie>();
            this.Ds = this.ReadDataFromFile(this.FilePath);//mandamos a llamar el metodo para leer el archivo
            DataTable xmlData = this.Ds.Tables[this.ParamName];

            foreach (DataRow row in xmlData.Rows)
            {
                Movie aux = new Movie(Int32.Parse(row["id"].ToString()), row["title"].ToString(), row["genre"].ToString());//convierte la tabla a cadena de texto 

                list.Add(aux);// add añadir un elemento nuevo a la lista
            }

            return list;
        }

        public void AddMovie(Movie mov)
        {
            List<Movie> movies = this.GetList();

            // Obtenemos el id mas alto con ayuda de la libreria System.Linq
            int lastId = movies.Max(x => x.Id);

            DataRow dr = this.Ds.Tables[0].NewRow();
            dr["id"] = lastId + 1;
            dr["title"] = mov.Title;
            dr["genre"] = mov.Genre;
            this.Ds.Tables[0].Rows.Add(dr);
            this.WriteFile();
        }

        public void DeleteMovie(int id)
        {
            this.GetList(); // Solo se manda a llamar para asegurarse que this.Ds se asigne

            int findIndex = -1;
            int i = 0;

            foreach (DataRow row in this.Ds.Tables[0].Rows)//Buscar la fila dentro del xml
            {
                if (Convert.ToInt32(row["id"]) == id)
                {
                    findIndex = i;//importa el lugar en la lista, para borrarlo, no el id en si 
                    break;
                }
                i++;
            }

            if (findIndex > -1)
            { // Solo se valida que si se haya encontrado
                this.Ds.Tables[0].Rows.RemoveAt(findIndex);
            }

            this.WriteFile();
        }

        public void EditMovie(Movie mov)
        {
            int findIndex = -1;
            int i = 0;

            foreach (DataRow row in this.Ds.Tables[0].Rows)//Buscar la fila dentro del xml
            {
                if (Convert.ToInt32(row["id"]) == mov.Id)
                {
                    findIndex = i;//importa el lugar en la lista, para borrarlo, no el id en si 
                    break;
                }
                i++;
            }

            if (findIndex > -1)
            { // Solo se valida que si se haya encontrado
                DataRow auxRow = this.Ds.Tables[0].Rows[findIndex];

                auxRow["title"] = mov.Title;
                auxRow["genre"] = mov.Genre;
            }

            this.WriteFile();
        }

    }
}
