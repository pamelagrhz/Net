/*  
 * Creamos una clase de modelos generica con los atributos que normalmente comparten todos los modelos
 * Las otras clases van a extender de esta clase. Por lo tanto, las clases que extiendan de esta van
 * a tener los atributos "id" y "name".
 * Se declaran con el modificador de acceso "protected" para poder acceder a estos desde las clases hijas.
*/


using System;
namespace PaisesYPlatillos.Models
{
    public class GenericModel
    {
        public GenericModel()
        {
        }

        public GenericModel(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
