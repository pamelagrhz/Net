using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace PF
{
    public class SocketServidor
    {

        private struct InfoCte
        {
            public Socket socket;
            public Thread thread;
            public string lastMsg;

        }

        #region variables

        private TcpListener tcpLsn;
        private Hashtable clientes = new Hashtable();
        private Thread tcpThd;
        private IPEndPoint cteAct;
        #endregion  variables

        /* delegado es una funcion que llama a otra funcion para crear un evento que es un paradigma que cambia algo (boton) 
        esperamos que suceda algo */

        //firma de las funciones de los eventos 
        public delegate void DNvaCnx(IPEndPoint id);
        public delegate void DDatos(IPEndPoint id);
        public delegate void DEndCnx(IPEndPoint id);

        //nombrado de los eventos 
        public DNvaCnx NuevaConexion;
        public DDatos DatosRecibidos;
        public DEndCnx ConexionTerminada;

        private string pto;
        public string Pto { set { pto = value; } }


        public void Escuchar()
        {
            //crea un nuevo servidor tcpLsn y lanza un hilo para poder hacer cosas en paralelo 

            this.tcpLsn = new TcpListener(
                Convert.ToInt32(pto));
            tcpLsn.Start();
            tcpThd = new Thread(new ThreadStart(
                EsperarCliente));
            tcpThd.Start();
        }


        private void EsperarCliente()
        {
            //throw new NotImplementedException();
            InfoCte cte = new InfoCte();
            while (true)
            {
                cte.socket = tcpLsn.AcceptSocket();
                this.cteAct = (IPEndPoint)cte.socket.RemoteEndPoint;
                cte.thread = new Thread(new ThreadStart(LeerSocket));


                lock (this)
                {
                    clientes.Add(cteAct, cte);
                }
                //Lanzamos un evento
                this.NuevaConexion(cteAct);
                cte.thread.Start();


            }
        }


        private void LeerSocket()
        {
            IPEndPoint id = this.cteAct;
            byte[] buffer;
            //la direccion ip será el id y verificamos si esta conectado, si lo está recuperamos lo que tiene 
            InfoCte cte = (InfoCte)clientes[id];
            int ret = 0;
            while (true)
            {
                if (cte.socket.Connected)
                {
                    buffer = new byte[128];
                    try
                    {
                        ret = cte.socket.Receive(buffer, buffer.Length, SocketFlags.None);
                        if (ret > 0)//si tenemos datos
                        {
                            cte.lastMsg = Encoding.ASCII.GetString(buffer);
                            clientes[id] = cte;
                            //lazamos evento
                            this.DatosRecibidos(id);

                        }
                        else
                        {
                            //si no me envia nada, mato el proceso
                            this.ConexionTerminada(id);
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        //metemos la siguiente validacion pero comprobamos si está conectado
                        if (!cte.socket.Connected)
                        {
                            this.ConexionTerminada(id);
                            break;
                        }
                    }
                }
            }

            CerrarThread(id);

        }
        private void CerrarThread(IPEndPoint id)
        {
            InfoCte cte = (InfoCte)clientes[id];
            try
            {
                cte.thread.Abort();

            }
            catch (Exception ex)
            {
                lock (this)
                {
                    clientes.Remove(id);
                }

            }
        }

        public String ObtenerDatos(IPEndPoint id)
        {
            InfoCte cte = (InfoCte)clientes[id];
            return cte.lastMsg;

        }

        public void Cerrar(IPEndPoint id)
        {
            foreach (InfoCte cte in clientes)

                cte.socket.Close();
        }

        public void EnviarDatos(IPEndPoint id,string msg)
        {
            InfoCte cte = (InfoCte)clientes[id];
            cte.socket.Send(Encoding.ASCII.GetBytes(msg));

        }
        public void EnviarDatos(string msg)
        {
            foreach (InfoCte cte in clientes)
                cte.socket.Send(Encoding.ASCII.GetBytes(msg));

        }
    }
}
