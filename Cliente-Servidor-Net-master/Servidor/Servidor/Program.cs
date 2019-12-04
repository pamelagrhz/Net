using System;
using System.Net;

namespace Servidor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Servidor svr = new Servidor(IPAddress.Parse("127.0.0.1"),18000);
            svr.Escuchar();
        }


    }
}
