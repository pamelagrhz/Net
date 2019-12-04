/*
 * Este archivo sirve para establecer el modelo de los objetos de platillos.
*/

using System;

namespace PaisesYPlatillos.Models
{
    public class Saucer : GenericModel
    {
        public Saucer() //un constructor vacio
        {

        }
		public Saucer(int id, string name) //un constructor vacio
		{
			this.Id = id;
			this.Name = name;		   }
        public Saucer(string saucersName, int countryId) //constructor para recibir los dos parametros del default
        {
            this.Name = saucersName;
            this.PaisId = countryId;
        }

        public Saucer(string name) //constructor con 1 atributos
        {
            this.Name = name;
        }

        public Saucer(int id, string name, int paisId): base(id) //constructor con 2 atributos
        {
            this.Name = name;
            this.PaisId = paisId;
        }

        public Saucer(int id, string name, int paisId, Country pais) : base(id) //constructor con 2 atributos
        {
            this.Name = name;
            this.PaisId = paisId;
            this.Pais = pais;
        }

        // Atributos de la clase
        public string Name { get; set; }
        public int PaisId { get; set; }
        public Country Pais { get; set; }
        public string PaisNombre { get; set; }

        public static explicit operator Saucer(Country v)
        {
            throw new NotImplementedException();
        }
    }
}
