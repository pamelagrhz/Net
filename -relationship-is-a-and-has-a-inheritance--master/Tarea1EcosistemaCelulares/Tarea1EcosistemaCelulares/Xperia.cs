namespace Tarea1EcosistemaCelulares
{
    internal class Xperia :Celular //Herencia
    {
        int Precio;//Atributos

        public Xperia(string ap, int b)
        {
            this.Fabricante = ap;
            this.Precio = b;
        }


        //Sobrecarga de ToString
        public override string ToString()
        {
            string res;
            res = base.ToString() + "\n";
            res += string.Format("[Xperia: Precio=${0}]", Precio);
            return res;
        }

    }
}