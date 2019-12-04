namespace Tarea1EcosistemaCelulares
{

    public class  Pantalla
    {
    float tamaño;//Declaramos los atributos
        //Dejamos vacio el constructor
        public Pantalla()
        {
        }
        //getters y setters
        public float Tamaño { get => tamaño; set => tamaño = value; }
        //Sobrecarga de  ToString
        public override string ToString()
        {
            return string.Format("[Pantalla: tamaño={0}Pulgadas]", tamaño);
        }
    }
}