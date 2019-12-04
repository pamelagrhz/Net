using System;
using System.Net;

namespace PF
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //solo pasamos como parametro un numero de puerto
            SocketServidor svr = new SocketServidor();
            svr.Pto = "6969";
            svr.Escuchar();
            Console.WriteLine("Servidor Iniciado");

            //creo una instancia de mi propia clase
            MainClass main = new MainClass();
            svr.NuevaConexion += new SocketServidor.DNvaCnx(main.AlguienSeConecto);

        }
        //creamos una sobrecarga
        public void AlguienSeConecto(IPEndPoint id)
        {
            Console.WriteLine("Un cliente {0} llego!....",id.ToString());
        }
        public void AlguienHablo()
        {
            Console.WriteLine("Un cliente hablo!....");
        }
    }
}
