using System;
using System.Net;

namespace Ponto_Contar
{
    public class Util
    {
        public static string CaminhoBD()
        {
            return @"G:\Documentos\HeadThink\Ponto";
        }

        public static string RetonarIP()
        {
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            return ip[1].ToString();
        }

        public static string RetornarNomeMaquina()
        {
            return Environment.MachineName;
        }

    }
}
