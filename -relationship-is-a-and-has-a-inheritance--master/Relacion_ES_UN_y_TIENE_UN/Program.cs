using System;

namespace Relacion_ES_UN_y_TIENE_UN
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AlienWare alien = new AlienWare("DELL",32000);

            Pavillion pav = new Pavillion("HP", 4000, true);
            pav.DiscoDuro = new DiscoDuro();
            pav.DiscoDuro.Capacidad = 8;
            pav.DiscoDuro.Tipo = true;
            pav.MemoriaRam = new Memoria();
            pav.MemoriaRam.Capacidad = 8;


           // Console.WriteLine(alien);
            Console.WriteLine(pav);
            Console.ReadKey();

        }
    }
}
