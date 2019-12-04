

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Servidor
{
    public class Servidor
    {
        private TcpListener server;
        private IPAddress ip;
        private int pto;
        string resp;




        public Servidor(IPAddress ip, int pto)
        {
            this.ip = ip;
            this.pto = pto;
            Console.WriteLine("Servidor iniciado");
        }


        public void Escuchar()
        {
            server = new TcpListener(ip, pto);
            server.Start();//lo iniciamos

            while (true)
            {
               
                Console.WriteLine("Esperando Clientes...");
                TcpClient client = server.AcceptTcpClient();
                //cliente conectado
                Console.WriteLine(" cliente conectado...");
                NetworkStream canal = client.GetStream();

                //enviamos un mensaje 
                /*byte[] buffer = Encoding.ASCII.GetBytes(resp);
                canal.Write(buffer, 0, buffer.Length);*/

                //recibimos el mensaje del cliente con buffer2
                byte[] buffer2 = new byte[256];
                int tam = canal.Read(buffer2, 0, buffer2.Length);
                string msg = Encoding.ASCII.GetString(buffer2, 0, tam);
                Console.WriteLine("Mensaje del cliente:{0}", msg);

                if (msg == "hola")
                {
                    resp = "HOLA(S)";
                }else if (msg=="adios") {
                    resp = "BYE(S)";
                }
                else if (msg=="") {
                    resp = "...(S)";
                }

                byte[] respuesta = Encoding.ASCII.GetBytes(resp);
                canal.Write(respuesta, 0, respuesta.Length);
                Console.WriteLine("respondiendo:{0}", resp);
               
                //no ha enviado el mensaje 
            }


        }
        
    }
}
