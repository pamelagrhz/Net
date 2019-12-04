namespace Tarea1EcosistemaCelulares
{
 

  public class Almacenamiento
    {
        private int capacidad;//declaramos la variable
        //dejamos el constructor vacio 
        public Almacenamiento()
        { }
        //hacemos getters y setters
        public int Capacidad { get => capacidad; set => capacidad = value; }
        //sobrecargamos el ToString
        public override string ToString()
        {
            return string.Format("[Almacenamiento: Capacidad={0}GB]", Capacidad);
        }
    }


}