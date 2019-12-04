using System;
namespace Relacion_ES_UN_y_TIENE_UN
{
    public class Pavillion : Computadora //Herencia
    {

        bool subsidiaria; //atributos


        public Pavillion( string hp, int i, bool b){
          
            this.Fabricante = hp;
            this.Precio = i;
            this.subsidiaria = b;
        }
        //Sobrecargamos toString
        public override string ToString()
        {
            string res;
            //creamos una variable res 
            res = base.ToString() +"\n"; 
            //es en base con su papá y le damos un salto de linea
            res += string.Format("[Pavillion:subsidiaria={0}] ", subsidiaria);
        return res;

          
        }
    }
}