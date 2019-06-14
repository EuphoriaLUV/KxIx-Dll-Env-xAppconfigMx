using System;
using System.Xml.Serialization;

namespace xAppConfigMx
{
    public class xReviewEnv
    {
        [XmlElement(ElementName = "Use")]
        public int Use { get; set; }

        [XmlElement(ElementName = "UseFavorite")]
        public int UseFavorite { get; set; }

        [XmlElement(ElementName = "UseServerControl")]
        public int UseServerControl { get; set; }

        [XmlElement(ElementName = "PeriodMIN")]
        public int PeriodMin { get; set; }

        [XmlElement(ElementName = "StartHour")]
        public int StartHour { get; set; }

        [XmlElement(ElementName = "EndHour")]
        public int EndHour { get; set; }

        public xReviewEnv()
        {
            Use                 = 0;
            UseFavorite         = 0;
            UseServerControl    = 0;
            PeriodMin           = 3600;

            StartHour           = 0;
            EndHour             = 7;
        }

        public xReviewEnv(int use, int useFavorite, int useServerControl, int periodMin, int startHour, int endHour)
        {
            Use                 = use;
            UseFavorite         = useFavorite;
            UseServerControl    = useServerControl;

            PeriodMin           = periodMin;

            StartHour           = startHour;
            EndHour             = endHour;
        }
    }
}
