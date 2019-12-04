using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using PaisesYPlatillos.Models;


namespace PaisesYPlatillos.Controllers
{
    public class SaucersController : Controller
    {


        public SaucersController() : base("platillos.xml", "platillos")
        {

        }

        private DataSet CountriesDs = new DataSet();

        public List<Saucer> GetList()
        {
            List<Saucer> list = new List<Saucer>();
            this.Ds = this.ReadDataFromFile(this.FilePath);//mandamos a llamar el metodo para leer el archivo
            DataTable xmlData = this.Ds.Tables[this.ParamName];

            List<Country> countriesList = new List<Country>();
            this.CountriesDs = this.ReadDataFromFile(this.DataFilePath + "paises.xml");
            DataTable countriesXmlData = this.CountriesDs.Tables["paises"];

            foreach (DataRow row in countriesXmlData.Rows)
            {
                Country aux = new Country(Int32.Parse(row["id"].ToString()), row["name"].ToString());
                countriesList.Add(aux);// add añadir un elemento nuevo a la lista
            }

            foreach (DataRow row in xmlData.Rows)
            {

                Saucer aux = new Saucer(Int32.Parse(row["id"].ToString()), row["name"].ToString(), Int32.Parse(row["paisId"].ToString()));//convierte la tabla a cadena de texto 
                Country paisAux = countriesList.Where(x => x.Id == aux.PaisId).ToList()[0];
                aux.Pais = paisAux;
                aux.PaisNombre = paisAux.Name;

                list.Add(aux);// add añadir un elemento nuevo a la lista
            }

            return list;
        }

        public void AddSaucer(Saucer sau)
        {
            try
            {
                List<Saucer> saucers = this.GetList();

                // Obtenemos el id mas alto con ayuda de la libreria System.Linq
                int lastId = saucers.Max(x => x.Id);

                DataRow dr = this.Ds.Tables[0].NewRow();
                dr["id"] = lastId + 1;
                dr["name"] = sau.Name;//nombres de la base de datos saucer
                dr["paisId"] = sau.PaisId;

                this.Ds.Tables[0].Rows.Add(dr);
                this.WriteFile();
            }
            catch (System.NullReferenceException e)
            {
                throw e;
            }
        }

        public void DeleteSaucer(int id)
        {
            DataRow dr = this.Ds.Tables[0].NewRow();

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

		public void EditSaucer(Saucer sau)
		{
			int findIndex = -1;
			int i = 0;

			foreach (DataRow row in this.Ds.Tables[0].Rows)//Buscar la fila dentro del xml
			{
				if (Convert.ToInt32(row["id"]) == sau.Id)
				{
					findIndex = i;//importa el lugar en la lista, para borrarlo, no el id en si 
					break;
				}
				i++;
			}

			if (findIndex > -1)
			{ // Solo se valida que si se haya encontrado
				DataRow auxRow = this.Ds.Tables[0].Rows[findIndex];

				auxRow["name"] = sau.Name;
				auxRow["paisId"] = sau.PaisId;
			
			}

			this.WriteFile();
				}

    }
}
