using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using PaisesYPlatillos.Models;

namespace PaisesYPlatillos.Controllers
{
    public class CountriesController : Controller
    {
        public CountriesController() : base("paises.xml", "paises")
        {
        }

        private string SaucersFilePath = "platillos.xml";
        private DataSet SaucersDs = new DataSet();

        public List<Country> GetList()
        {
            List<Country> list = new List<Country>();
            this.Ds = this.ReadDataFromFile(this.FilePath);//mandamos a llamar el metodo para leer el archivo
            DataTable xmlData = this.Ds.Tables[this.ParamName];

            List<Saucer> saucersList = new List<Saucer>();
            this.SaucersDs = this.ReadDataFromFile(this.DataFilePath + this.SaucersFilePath);
            DataTable saucersXmlData = this.SaucersDs.Tables["platillos"];

            foreach (DataRow row in saucersXmlData.Rows)
            {
                Saucer aux = new Saucer(Int32.Parse(row["id"].ToString()), row["name"].ToString(), Int32.Parse(row["paisId"].ToString()));
                saucersList.Add(aux);// add añadir un elemento nuevo a la lista
            }

            int i = 0;

            foreach (DataRow row in xmlData.Rows)
            {
                Country aux = new Country(Int32.Parse(row["id"].ToString()), row["name"].ToString());//convierte la tabla a cadena de texto 
                list.Add(aux);// add añadir un elemento nuevo a la lista

                list[i].Saucers = saucersList.Where(x => x.PaisId == aux.Id).ToList();

                i++;
            }

            return list;
        }
    }
}
