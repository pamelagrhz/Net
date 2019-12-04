namespace PracticaPorObjetivos1
{
    internal class Alimentos : Producto
    {
        private string nombre;
        private int precio;
        private int calorias;

        public Alimentos(string nombre, int precio, int calorias)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.calorias = calorias;
        }

        public string Nombre1 { get => nombre; set => nombre = value; }
        public int Precio1 { get => precio; set => precio = value; }
        public int Calorias { get => calorias; set => calorias = value; }

        public override string ToString()
        {
            string s="";
            s+=string.Format("[Alimentos: nombre={0}, precio={1}, calorias={2}]", nombre, precio, calorias);
            return s;
        }
    }
}
