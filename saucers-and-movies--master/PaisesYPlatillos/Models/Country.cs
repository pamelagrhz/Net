/*
 * Este archivo sirve para establecer el modelo de los objetos de Paises.
*/

using System;
using System.Collections.Generic;

namespace PaisesYPlatillos.Models
{
    public class Country : GenericModel
    {
        public Country() //un constructor vacio
        {

        }

        public Country(string name) //constructor con 2 atributos
        {
            this.Name = name;
        }

        public Country(int id, string name): base(id) //constructor con 2 atributos
        {
            this.Name = name;
        }

        // Getters y setters
        // Atributos de la clase
        public string Name { get; set; }
        public List<Saucer> Saucers { get; set; }

        public static implicit operator Country(Saucer v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Country(string v)
        {
            throw new NotImplementedException();
        }
    }
}
