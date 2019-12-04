using System;
namespace Relacion_ES_UN_y_TIENE_UN
{
    public class DiscoDuro
    {
        private int capacidad;
        private bool tipo;
        public DiscoDuro()
        {
        }

        public int Capacidad { get => capacidad; set => capacidad = value; }
        public bool Tipo { get => tipo; set => tipo = value; }

        //cmd I ; to string, disco duro y tipo seleccionados; enter
        public override string ToString()
        {
            return string.Format("[DiscoDuro: capacidad={0}, tipo={1}]", Capacidad,
            Tipo ? "SSD":"Magnético");// condicional; si no es ssd es magnetico 
        }
    }
}
