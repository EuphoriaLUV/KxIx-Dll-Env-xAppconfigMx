using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace xAppConfigMx
{

    [XmlRoot("KxIx")]
    public class xAppEnv
    {
        [XmlIgnoreAttribute]
        public int DatabaseType
        {
            get
            {
                return _databaseType;
            }
        }

        [XmlIgnoreAttribute]
        public int UseDBItemChk
        {
            get
            {
                return _option.UseDBItemChk;
            }
            set
            {
                _option.UseDBItemChk = value;
            }
        }

        [XmlIgnoreAttribute]
        public int UseWebItemTitle
        {
            get
            {
                return _option.UseWebItemTitle;
            }
            set
            {
                _option.UseWebItemTitle = value;
            }
        }

        [XmlIgnoreAttribute]
        public string HistoryPath
        {
            get
            {
                return _historyPath.Path;
            }
            set
            {
                _historyPath.Path = value;
            }
        }

        public string Host
        {
            get
            {
                return _host.ToString();
            }
        }

        public string RunDBFile
        {
            get
            {
                return _liteDBPath.Run.ToString();
            }
        }

        public string ItemDBFile
        {
            get
            {
                return _liteDBPath.Item.ToString();
            }
        }

        public string DeviceDBFile
        {
            get
            {
                return _liteDBPath.Device.ToString();
            }
        }

        public string ReviewDBFile
        {
            get
            {
                return _liteDBPath.Review.ToString();
            }
        }

        public string RankingDBFile
        {
            get
            {
                return _liteDBPath.Ranking.ToString();
            }
        }

        public string PartnerZoneDBFile
        {
            get
            {
                return _liteDBPath.Partnerzone.ToString();
            }
        }

        [XmlIgnoreAttribute]
        public xReviewEnv Review
        {
            get
            {
                return _review;
            }
            set
            {
                _review = value;
            }
        }

        [XmlIgnoreAttribute]
        public xPurchaseEnv Purchases
        {
            get
            {
                return _purchase;
            }
            set
            {
                _purchase = value;
            }
        }


        [XmlElement(ElementName = "DataBaseType")]
        public int _databaseType { get; set; }      

        [XmlElement(ElementName = "MDataBase")]
        public xMDBPath _host;                      

        [XmlElement(ElementName = "DataBase")]
        public xLDBPaths _liteDBPath;

        [XmlElement(ElementName = "OPTION")]
        public xOption _option;

        [XmlElement(ElementName = "HISTORY")]
        public SPath _historyPath;

        [XmlElement(ElementName = "SMS_ALIMI")]
        public xSMSAlimi _SMS;

        [XmlElement(ElementName = "Review")]
        public xReviewEnv _review;

        [XmlElement(ElementName = "Purchases")]
        public xPurchaseEnv _purchase;


        public xAppEnv()
        {
            _databaseType = 0;

            _host               = new xMDBPath("192.168.0.200", "3307");

            _liteDBPath         = new xLDBPaths() {
                                        Run          = new xLDBPath(@"C:\KxIx\DataBase\Run\", "KxIxRun.db"),
                                        Item         = new xLDBPath(@"C:\KxIx\DataBase\Item\", "RentalItem.db"),
                                        Device       = new xLDBPath(@"C:\KxIx\DataBase\Device\", "Device.db"),
                                        Review       = new xLDBPath(@"C:\KxIx\DataBase\Review\", "Review.db"),
                                        Ranking      = new xLDBPath(@"C:\KxIx\DataBase\Ranking\", "Ranking.db"),
                                        Partnerzone  = new xLDBPath(@"C:\KxIx\DataBase\Partnerzone\", "Partnerzone.db"),
            };

            _option             = new xOption(0, 0);

            _historyPath        = new SPath(@"C:\KxIx\History\");

            _SMS                = new xSMSAlimi();
            _review             = new xReviewEnv();
            _purchase           = new xPurchaseEnv();
            
        }
    }

    public class SPath
    {
        [XmlElement(ElementName = "PATH")]
        public string Path { get; set; }

        public SPath()
        {
            Path = "";
        }

        public SPath(string path)
        {
            Path = path;
        }
    }
}
