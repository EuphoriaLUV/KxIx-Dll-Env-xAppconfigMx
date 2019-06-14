using System;
using System.Xml.Serialization;

namespace xAppConfigMx
{
    public class xPurchaseEnv
    {
        [XmlElement(ElementName = "Use")]
        public int Use { get; set; }

        [XmlElement(ElementName = "UseServerControl")]
        public int UseServerControl { get; set; }

        [XmlElement(ElementName = "MusicPath")]
        public string MusicPath { get; set; }

        [XmlElement(ElementName = "PeriodMIN")]
        public int PeriodMin { get; set; }

        [XmlElement(ElementName = "StartHour")]
        public int StartHour { get; set; }

        [XmlElement(ElementName = "EndHour")]
        public int EndHour { get; set; }

        public xPurchaseEnv()
        {
            Use                 = 0;
            UseServerControl    = 0;
            MusicPath           = "";
            PeriodMin           = 3600;

            StartHour           = 8;
            EndHour             = 23;
        }

        public xPurchaseEnv(int use, int useServerControl, int periodMin, int startHour, int endHour)
        {
            Use                 = use;
            UseServerControl    = useServerControl;
            MusicPath           = "";
            PeriodMin           = periodMin;

            StartHour           = startHour;
            EndHour             = endHour;
        }
    }
}
