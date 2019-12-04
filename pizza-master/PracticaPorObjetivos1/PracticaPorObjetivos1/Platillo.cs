namespace PracticaPorObjetivos1
{
    internal class Platillo
    {
        private string nombre;
        private Alimentos[] ingredientes;
      

        internal Alimentos[] Ingredientes { get => ingredientes; set => ingredientes = value; }

        public Platillo(string v)
        {
            this.nombre = v;
        }


        public override string ToString()
        {
            double tCalorias = 0;
            double tCosto = 0;
            string salida = string.Format("[Platillo: nombre={0}]", nombre);

            foreach (Alimentos a in this.ingredientes)
            {
                salida += "\n" + a.ToString();
                tCalorias += a.Calorias;
                tCosto += a.Precio1;
            }
            salida += string.Format("\n TOTALES: Costo:{0} \nCalorias:{1}", tCosto, tCalorias);
            return salida;
        }

   
    }
};
