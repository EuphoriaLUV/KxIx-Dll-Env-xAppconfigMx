using System;
using System.Xml.Serialization;

namespace xAppConfigMx
{
    public class xOption
    {
        [XmlElement(ElementName = "UseDBItemChk")]
        public int UseDBItemChk     { get; set; }

        [XmlElement(ElementName = "UseWebItemTitle")]
        public int UseWebItemTitle  { get; set; }

        public xOption()
        {
            UseDBItemChk = 0;
            UseWebItemTitle = 0;
        }

        public xOption(int useDBItemChk, int useWebItemTitle)
        {
            UseDBItemChk = useDBItemChk;
            UseWebItemTitle = useWebItemTitle;
        }
    }
}
