using System;
using System.Threading;


namespace LaLiebreYLaTortuga
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int t = 1;


            Thread th = new Thread(new ThreadStart(Ciclo));
            th.Start();

            while (t < 101)
            {
                Thread.Sleep(4);//dormimos un milisegundo
                Console.Write("({0})T  ", t);
                t++;
            }

            Console.Write(">>TORTUGA WINS!<< ");
            Console.ReadKey();


        }

        public static void Ciclo()
        {
            System.Random rnd = new System.Random();
            int l = 1;
            int r = rnd.Next(60, 70);

            while (l < 101)
            {

                if (l == r)
                {
                    Console.WriteLine("L SE DURMIÓ ");
                    Thread.Sleep(250);//dormimos un milisegundo
                    Console.WriteLine("L DESPERTÓ");
                }
                else
                {
                    Thread.Sleep(3);//dormimos un milisegundo
                    Console.Write("({0})L  ", l);
                }
                l++;
            }

            Console.WriteLine("L CRUZÓ LA META");
            Console.ReadKey();


        }
    }
}
