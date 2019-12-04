using System;
namespace Relacion_ES_UN_y_TIENE_UN
{
    public class Memoria
    {
        private int capacidad;



     

        public Memoria()
        {
          
        }

        public int Capacidad { get => capacidad; set => capacidad = value; }

        public override string ToString()
        {
          
            return string.Format("[Memoria: capacidad={0}GB]", capacidad);
           
        }

        //sobrecargamos string

    }
}
