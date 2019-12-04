using System;

namespace Tarea1EcosistemaCelulares
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IPhone ip = new IPhone("Apple", 13000);
            Xperia xp = new Xperia("Sony", 7000);
            MotoG mg = new MotoG("Motorola", 3000);

            ip.MemoriaRam = new MemoriaR();
            ip.Camara = new Camara();
            ip.MemoriaInterna = new Almacenamiento();
            ip.Tamaño = new Pantalla();
            //ip.Tamaño = new Tamaño();


            ip.MemoriaRam.Capacidad = 8;//inicializamos ram,camara, memoria interna y tamaño de pantalla para Iphone
            ip.Camara.Pixeles = 30;
            ip.MemoriaInterna.Capacidad = 32;
            ip.Tamaño.Tamaño = 5.6f;//se declara con f pues es flotante

            xp.MemoriaRam = new MemoriaR();//inicializamos ram,camara, memoria interna y tamaño de pantalla para Xperia
            xp.Camara = new Camara();
            xp.MemoriaInterna = new Almacenamiento();
            xp.Tamaño = new Pantalla();

            xp.Camara.Pixeles=20;
            xp.MemoriaRam.Capacidad = 4;
            xp.MemoriaInterna.Capacidad = 32;
            xp.Tamaño.Tamaño = 4.5f;//se declara con f pues es flotante

            mg.MemoriaRam = new MemoriaR();//inicializamos ram,camara, memoria interna y tamaño de pantalla para MotoG
            mg.Camara = new Camara();
            mg.MemoriaInterna = new Almacenamiento();
            mg.Tamaño = new Pantalla();

            mg.Camara.Pixeles = 10;
            mg.MemoriaRam.Capacidad = 2;
            mg.MemoriaInterna.Capacidad = 32;
            mg.Tamaño.Tamaño = 5.5f;//se declara con f pues es flotante



            Console.WriteLine(ip+"\n");
            Console.WriteLine(xp + "\n");
            Console.WriteLine(mg + "\n");
            Console.ReadKey();

        }
    }
}
