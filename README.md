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
