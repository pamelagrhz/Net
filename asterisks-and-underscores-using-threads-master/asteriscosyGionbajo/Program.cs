using System;
using System.Threading;

namespace asteriscosyGionbajo
{
    class MainClass
    {
       

        public static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ciclo));
            t.Start();
            while(true)
            {
                Thread.Sleep(1);//dormimos un milisegundo
                Console.Write("*");
            }


        }

        public static void ciclo()
        {
            while (true)
            {
                Thread.Sleep(1);//dormimos un milisegundo
                Console.Write("_");
            }
        }



    }
}
