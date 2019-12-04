using System;
namespace Tarea1EcosistemaCelulares
{
    abstract public class Celular
    {
        //declaramos las variables con el tipo de las otras clases
        private Almacenamiento memoriaInterna;
        private MemoriaR memoriaRam;
        private Camara  camara;
        private Pantalla tamaño;
        private string fabricante;

        //dejamos el constructor vacio 
        public Celular()
        {
        }
        // ahora creamos getters y setters 
        public Almacenamiento MemoriaInterna { get => memoriaInterna; set => memoriaInterna = value; }
        public MemoriaR MemoriaRam { get => memoriaRam; set => memoriaRam = value; }
        public Camara Camara { get => camara; set => camara = value; }
        public Pantalla Tamaño { get => tamaño; set => tamaño = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }

        //realizamos un toString con sobrecarga
        public override string ToString()
        {
            return string.Format("[Celular: MemoriaInterna={0}, MemoriaRam={1}, Camara={2}, Tamaño={3}, Fabricante={4}]", MemoriaInterna, MemoriaRam, Camara, Tamaño, Fabricante);
        }
    }
}
