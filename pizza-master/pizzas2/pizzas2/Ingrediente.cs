using System;
namespace pizzas2
{
    public class Ingrediente
    {
        public string nombre;
        public int calorias;

        public Ingrediente(string nombre, int calorias)
        {
            this.nombre = nombre;
            this.calorias = calorias;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre, calorias);
        }

        public static explicit operator int(Ingrediente v)
        {
            throw new NotImplementedException();
        }
    }
}
