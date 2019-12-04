using System;

namespace Prueba
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(Dec2Bin(5));
            //Console.WriteLine(Bin2Dec('101'));

            for (int x = 1; x <= 1000; x++)
                Console.WriteLine(x.Dec2Bin());
            Console.ReadKey();
        }

    }

}