using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace xAppConfigMx
{
    public class xSMSAlimi
    {
        [XmlElement(ElementName = "USE")]
        public int Use { get; set; }

        [XmlArray("PHONE_NUMBERS")]
        [XmlArrayItem(typeof(string), ElementName = "PHONE")]
        public List<string> PhoneNumbers;

        public xSMSAlimi()
        {
            Use = 0;
            PhoneNumbers = new List<string>();
        }

        public xSMSAlimi(int _use)
        {
            Use = _use;
            PhoneNumbers = new List<string>();
        }
    }
}
