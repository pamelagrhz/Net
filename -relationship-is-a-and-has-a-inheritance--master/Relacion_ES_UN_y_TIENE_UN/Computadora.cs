using System;
namespace Relacion_ES_UN_y_TIENE_UN
{
    public abstract  class Computadora//abstract 
    {
        private Memoria memoriaRam;
        private DiscoDuro discoDuro;
        private String fabricante;
        private double precio;

     


        public Computadora()
        {
           
        }

        public Memoria MemoriaRam { get => memoriaRam; set => memoriaRam = value; }
        public DiscoDuro DiscoDuro { get => discoDuro; set => discoDuro = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return string.Format("[Computadora: MemoriaRam={0}, DiscoDuro={1}, Fabricante={2}, Precio={3}]", MemoriaRam, DiscoDuro, Fabricante, Precio);
        }

    }
}
