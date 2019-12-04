using System;
using System.Net;

namespace Cliente
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cliente cte =new Cliente(IPAddress.Parse("127.0.0.1"), 18000);
            cte.Conectar();
            Console.ReadKey();
        }
    }
}
