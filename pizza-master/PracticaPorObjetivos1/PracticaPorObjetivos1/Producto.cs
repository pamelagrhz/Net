using System;
namespace PracticaPorObjetivos1
{
     abstract class Producto
    {
        private double precio;
        private string nombre;
        public Producto()
        {
        }

        protected Producto(double precio, string nombre)
        {
            this.precio = precio;
            this.nombre = nombre;
        }

        public double Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }

       
    }
}
