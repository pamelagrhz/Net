using System;

namespace TestCliente
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SocketCliente cte = new SocketCliente();
            cte.IpSvr = "127.0.0.1";
            cte.PtoSvr = "6969";
            cte.Conectar();

            Console.WriteLine("Intento de coneccion...");
        }
    }
}
