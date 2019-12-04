using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Cliente
{
    public class Cliente
    {

        private TcpClient cte;
        private IPAddress ip;
        private int pto;

        public Cliente(IPAddress ip, int pto)
        {
            this.ip = ip;
            this.pto = pto;
            Console.WriteLine("Intentar conectar con :{0}",ip.ToString() + ":" + pto.ToString());
        }

        public void Conectar()
        {
           
            cte = new TcpClient(ip.ToString(), pto);
            NetworkStream canal = cte.GetStream();


            Console.WriteLine("CONECTADO");



            while (true)
            {
                //primer mensaje



                Console.Write("Ingresa un mensaje:");
                string r;
                r = Console.ReadLine();
                //enviamos un mensaje 
                byte[] buffer2 = Encoding.ASCII.GetBytes(r);
                canal.Write(buffer2, 0, buffer2.Length);

                byte[] buffer = new byte[256];
                int tam = canal.Read(buffer, 0, buffer.Length);
                string msg = Encoding.ASCII.GetString(buffer, 0, tam);
                Console.WriteLine("Mensaje del servidor:{0}", msg);


                cte.Close();

            }




        }

    }
}

