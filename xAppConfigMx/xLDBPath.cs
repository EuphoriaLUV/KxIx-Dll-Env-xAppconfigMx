using System;
using System.IO;
using System.Xml.Serialization;

namespace xAppConfigMx
{
    public class xLDBPath : IxDBPath
    {
        [XmlElement(ElementName = "Path")]
        public string Path { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        public string HostName
        {
            get
            {
                return Path + Name;
            }
        }

        public bool Exists
        {
            get
            {
                FileInfo info = new FileInfo(HostName);
                return info.Exists;
            }
        }

        public override string ToString()
        {
            return HostName;
        }

        public xLDBPath()
        {
            Path = "";
            Name = "";
        }

        public xLDBPath(string _path, string _name)
        {
            Path = _path;
            Name = _name;
        }
    }

    public class xLDBPaths
    {
        [XmlElement(ElementName = "Item")]
        public xLDBPath Item { get; set; }

        [XmlElement(ElementName = "Run")]
        public xLDBPath Run { get; set; }

        [XmlElement(ElementName = "Review")]
        public xLDBPath Review { get; set; }

        [XmlElement(ElementName = "Device")]
        public xLDBPath Device { get; set; }

        [XmlElement(ElementName = "Partnerzone")]
        public xLDBPath Partnerzone { get; set; }

        [XmlElement(ElementName = "Ranking")]
        public xLDBPath Ranking { get; set; }


        public xLDBPaths()
        {
            Item            = new xLDBPath();
            Run             = new xLDBPath();
            Review          = new xLDBPath();
            Device          = new xLDBPath();
            Partnerzone     = new xLDBPath();
            Ranking         = new xLDBPath();
        }

        public xLDBPaths(xLDBPath item, xLDBPath run, xLDBPath review, xLDBPath device, xLDBPath partnerzone, xLDBPath ranking)
        {
            Item        = item;
            Run         = run;
            Review      = review;
            Device      = device;
            Partnerzone = partnerzone;
            Ranking     = ranking;
        }

    }
}
