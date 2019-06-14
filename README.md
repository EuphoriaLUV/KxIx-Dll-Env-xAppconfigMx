# KxIx-Dll-Env-xAppconfigMx
Model Class and Interface for KxIx Environment

## xOption
>Use Option

    [XmlElement(ElementName = "UseDBItemChk")]
    public int UseDBItemChk     { get; set; }

    [XmlElement(ElementName = "UseWebItemTitle")]
    public int UseWebItemTitle  { get; set; }

## IxDBPath
>DBPath Interface

    interface IxDBPath
    {
        string HostName { get; }
    }

## xLDBPath
>SQLite DB Path

    public class xLDBPath : IxDBPath
    {
        [XmlElement(ElementName = "Path")]
        public string Path { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        ...
    }

## xLDBPaths
>SQLite DB Paths    

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

## xLDBPaths
>Maria DB Path

    public class xMDBPath : IxDBPath
    {
        [XmlElement(ElementName = "IP")]
        public string IP { get; set; }

        [XmlElement(ElementName = "PORT")]
        public string Port { get; set; }

        ...
    }


## Environment File

    <?xml version="1.0" encoding="utf-8"?>
    <KxIx xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
      <MDataBase>
        <IP>192.168.0.200</IP>    or    <IP>106.246.89.122</IP>
        <PORT>3307</PORT>
      </MDataBase>
      <DataBase>
        <Item>
          <Path>Z:\RentalAutomator\DataBase\Item\</Path>
          <Name>RentalItem.db</Name>
        </Item>
        <Run>
          <Path>Z:\RentalAutomator\DataBase\Run\</Path>
          <Name>KxIxRun.db</Name>
        </Run>
        <Review>
          <Path>Z:\RentalAutomator\DataBase\Review\</Path>
          <Name>Review.db</Name>
        </Review>
        <Device>
          <Path>Z:\RentalAutomator\DataBase\Device\</Path>
          <Name>Device.db</Name>
        </Device>
        <Partnerzone>
          <Path>Z:\RentalAutomator\DataBase\Partnerzone\</Path>
          <Name>Partnerzone.db</Name>
        </Partnerzone>
        <Ranking>
          <Path>Z:\RentalAutomator\DataBase\Ranking\</Path>
          <Name>Ranking.db</Name>
        </Ranking>
      </DataBase>
      <OPTION>
        <UseDBItemChk>1</UseDBItemChk>
        <UseWebItemTitle>1</UseWebItemTitle>
      </OPTION>
      <HISTORY>
        <PATH>Z:\RentalAutomator\History\</PATH>
      </HISTORY>
      <SMS_ALIMI>
        <USE>0</USE>
        <PHONE_NUMBERS>
          <PHONE>01000000000</PHONE>
          <PHONE>01000000001</PHONE>
        </PHONE_NUMBERS>
      </SMS_ALIMI>
      <Review>
        <Use>1</Use>
        <UseFavorite>0</UseFavorite>
        <UseServerControl>0</UseServerControl>
        <PeriodMIN>300</PeriodMIN>
        <StartHour>0</StartHour>
        <EndHour>24</EndHour>
      </Review>
      <Purchases>
        <Use>1</Use>
        <UseServerControl>0</UseServerControl>
        <MusicPath>D:\Music</MusicPath>
        <PeriodMIN>300</PeriodMIN>
        <StartHour>15</StartHour>
        <EndHour>24</EndHour>
      </Purchases>
      <DataBaseType>2</DataBaseType>
    </KxIx>
