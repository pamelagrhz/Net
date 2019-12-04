using System;
using System.Collections.Generic;
using System.Data;

namespace PaisesYPlatillos.Controllers
{
    public class Controller
    {

        public Controller()
        {
        }

        // Definimos la ruta de la carpeta donde vamos a tener nuestra base de datos en archivos xml.
        // Por cada controller hijo se va a tener un nombre archivo diferente
        public Controller(string fileName, string name)
        {
            // Solo se le concatena el nombre del archivo.
            // Este contructor se va a encargar de armar la ruta completa del archivo xml.
            this.FilePath = this.DataFilePath + fileName;
            this.ParamName = name;
        }

        protected string FilePath { get; set; }
        protected string ParamName { get; set; }
        protected DataSet Ds { get; set; }
		// Variable constante para indicar donde esta la carpeta de los archivos xml
		protected readonly string DataFilePath = @"/Users/pamelaruiz/Projects/SaucersAndMovies-master/PaisesYPlatillos/data/";
		//protected readonly string DataFilePath = @"/Users/alejandrovillarroel/Projects/SaucersAndMovies/PaisesYPlatillos/data/";
		//protected readonly string DataFilePath = @"C:\Users\Pamela\Desktop\SaucersAndMovies-master\PaisesYPlatillos\data\";

        protected DataSet ReadDataFromFile(string filePath)
        {
            DataSet ds = new DataSet("Data");//transformar el archivo a objetos 
            ds.ReadXml(filePath);//leemos el xml
            return ds;//regresa la tabla que se llama peliculas 
        }

        protected void WriteFile()
        {
            this.Ds.WriteXml(this.FilePath);
        }
    }
}
