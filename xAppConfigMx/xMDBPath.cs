using System;
using System.Xml.Serialization;

namespace xAppConfigMx
{
    public class xMDBPath : IxDBPath
    {
        [XmlElement(ElementName = "IP")]
        public string IP { get; set; }

        [XmlElement(ElementName = "PORT")]
        public string Port { get; set; }

        public string HostName
        {
            get
            {
                string host = string.Format("Server={0}; Port={1};", IP, Port);
                return host;
            }
        }

        public override string ToString()
        {
            return HostName;
        }

        public xMDBPath()
        {
            IP      = "192.168.0.200";
            Port    = "3307";
        }

        public xMDBPath(string ip, string port)
        {
            IP      = ip;
            Port    = port;
        }
    }
}
