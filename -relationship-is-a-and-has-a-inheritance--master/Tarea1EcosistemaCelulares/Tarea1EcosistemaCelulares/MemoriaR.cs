namespace Tarea1EcosistemaCelulares
{
    public class MemoriaR
    {
        int capacidad;//declaramos los atributos
        //dejamos vacio el constructos
        public MemoriaR()
        {
        }
        //getters y setters
        public int Capacidad { get => capacidad; set => capacidad = value; }
        //sobrecargamos ToString
        public override string ToString()
        {
            return string.Format("[MemoriaR: capacidad={0}GB ]", capacidad);
        }
    }
}