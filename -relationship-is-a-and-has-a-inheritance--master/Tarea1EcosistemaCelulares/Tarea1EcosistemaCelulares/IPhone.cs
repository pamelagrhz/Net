namespace Tarea1EcosistemaCelulares
{
    internal class IPhone : Celular//Herencia
    {


        int Precio;//declaramos los atributos

        public IPhone(string ap, int b)
        {
            this.Fabricante = ap;
            this.Precio = b;
        }
        //sobrecarga de ToString
        public override string ToString()
        {
            string res;
                     res = base.ToString() + "\n";
            res += string.Format("[IPhone: Precio=${0}]", Precio);
            return res;
        }

       
    }
}