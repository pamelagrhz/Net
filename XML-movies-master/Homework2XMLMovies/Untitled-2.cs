using System;
using System.Collections.Generic;
using System.Data;
using PaisesYPlatillos.Models;


namespace PaisesYPlatillos.Controllers
{
    public class SaucersController : Controller
    {


        public SaucersController() : base("movies.xml", "movies")
        {

        }

        public List<Saucer> GetList()
        {
            List<Saucer> list = new List<Saucer>();
            DataTable xmlData = this.ReadDataFromFile(this.FilePath, this.ParamName);//mandamos a llamar el metodo para leer el archivo

            foreach (DataRow row in xmlData.Rows)
            {
                Saucer aux = new Saucer(Int32.Parse(row["id"].ToString()), row["title"].ToString(), row["genre"].ToString());//convierte la tabla a cadena de texto 

                list.Add(aux);// add añadir un elemento nuevo a la lista
            }

            return list;
        }

    }
}
