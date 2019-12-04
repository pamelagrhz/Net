using System;

namespace Random
{
    class MainClass
    {
        public static void Main(string[] args)
        {


                String[] p = new string[]
            {
                "obi","wan","ken","ky","lo","ren"
            };
                String[] g = new string[]
            {
                "Hombre","Mujer"
            };

            int c = 0;

           //p[i] = new Persona(nomale, edadAle, gAle);

                    System.Random rnd = new System.Random();
            for (int i = 0; i <= 999; i++)
            {
                int n = rnd.Next(0, p.Length);
                    int m = rnd.Next(0, p.Length);
                    int q = rnd.Next(0, p.Length);
                    int edad = rnd.Next(1, 80);
                    int b = rnd.Next(0, g.Length);
                c++;
    
                    Console.WriteLine(c+")  "+p[n] + p[m] + p[q] + " tiene " + edad + " años y es un(a) "+ g[b]);
               
                //Console.ReadKey();

                }
            //Console.ReadKey();

        }
    }
}
