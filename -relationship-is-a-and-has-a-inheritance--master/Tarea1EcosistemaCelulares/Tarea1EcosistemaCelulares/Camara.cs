namespace Tarea1EcosistemaCelulares
{
   
    public class Camara
    {
        private float pixeles;//declaramos la variable
        //Dejamos vacio el constructos
        public Camara()
        {
        }
        //getters y setters
        public float Pixeles { get => pixeles; set => pixeles = value; }
        //sobrecarga de ToString
        public override string ToString()
        {
            return string.Format("[Camara: pixeles={0} ]", pixeles);
        }
    }
}