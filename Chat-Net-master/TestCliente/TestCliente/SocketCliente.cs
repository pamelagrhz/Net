using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TestCliente
{
    public class SocketCliente
    {
        private Stream canal;
        public delegate void DDatos(string s);
        public DDatos ReciboDatos;
        public delegate void DEndCnx();
        public DEndCnx ConexionFinalizada;

        private string ipSvr;
        private string ptoSvr;
        public string IpSvr { set { ipSvr = value; } }
        public string PtoSvr{ set { ipSvr = value; }}
        public void Conectar()
        {
            TcpClient socket = new TcpClient();
            socket.Connect(ipSvr, Convert.ToInt32(ptoSvr));
            canal = socket.GetStream(); 
            Thread hilo = new Thread(new ThreadStart(LeerSocket));
            hilo.Start();
        }

        private void LeerSocket()
        {
            byte[] buffer = new byte[128];

            while (true)
            {
                try{
                    canal.Read(buffer, 0, buffer.Length);
                    this.ReciboDatos(Encoding.ASCII.GetString(buffer));
                    }
                catch (Exception ex) { break; }
            }
            this.ConexionFinalizada();
        }

        public void EnviarDatos(string msg)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(msg);
            if(canal.Length != 0)
            {
                canal.Write(buffer, 0, buffer.Length);
            }
        }

    }
}
