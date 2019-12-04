namespace Tarea1EcosistemaCelulares
{
    internal class MotoG : Celular //Herencia
    {

        int Precio;//atributos
        public MotoG(string ap, int b)
        {
            this.Fabricante = ap;
            this.Precio = b;
        }


        //sobrecarga de toString
        public override string ToString()
        {
            string res;
            res = base.ToString() + "\n";
            res += string.Format("[MotoG: Precio=${0}]", Precio);
            return res;
        }


    }
}