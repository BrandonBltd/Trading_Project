using System.Collections.Generic;

namespace TradingApp.Models
{
 


    public class USD
    {
         public string TYPE { get; set; }
            public string MARKET { get; set; }
            public string FROMSYMBOL { get; set; }
            public string TOSYMBOL { get; set; }
            public string FLAGS { get; set; }
            public string PRICE { get; set; }
            public string LASTUPDATE { get; set; }
            public string MEDIAN { get; set; }
            public string LASTVOLUME { get; set; }
            public string LASTVOLUMETO { get; set; }
            public string LASTTRADEID { get; set; }
            public string VOLUMEDAY { get; set; }
            public string VOLUMEDAYTO { get; set; }
            public string VOLUME24HOUR { get; set; }
            public string VOLUME24HOURTO { get; set; }
            public string OPENDAY { get; set; }
            public string HIGHDAY { get; set; }
            public string LOWDAY { get; set; }
            public string OPEN24HOUR { get; set; }
            public string HIGH24HOUR { get; set; }
            public string LOW24HOUR { get; set; }
            public string LASTMARKET { get; set; }
            public string VOLUMEHOUR { get; set; }
            public string VOLUMEHOURTO { get; set; }
            public string OPENHOUR { get; set; }
            public string HIGHHOUR { get; set; }
            public string LOWHOUR { get; set; }
            public string TOPTIERVOLUME24HOUR { get; set; }
            public string TOPTIERVOLUME24HOURTO { get; set; }
            public string CHANGE24HOUR { get; set; }
            public string CHANGEPCT24HOUR { get; set; }
            public string CHANGEDAY { get; set; }
            public string CHANGEPCTDAY { get; set; }
            public string CHANGEHOUR { get; set; }
            public string CHANGEPCTHOUR { get; set; }
            public string CONVERSIONTYPE { get; set; }
            public string CONVERSIONSYMBOL { get; set; }
            public string SUPPLY { get; set; }
            public string MKTCAP { get; set; }
           
            public string CIRCULATINGSUPPLYMKTCAP { get; set; }
            public string TOTALVOLUME24H { get; set; }
            public string TOTALVOLUME24HTO { get; set; }
        
               
    }

    public class RAW
    {
        public USD USD { get; set; }

        public RAW()
        {
            this.USD = new USD();
        }
    }



    public class Datum
    {
     
        public RAW RAW { get; set; }
       

        public Datum()
        {
            this.RAW = new RAW();
            
        }
    }

    public class RateLimit
    {
    }

    public class CryptoInfo
    {
       
    
        public List<Datum> Data { get; set; }
    

        public CryptoInfo()
        {
            this.Data = new List<Datum>();
        }
        
        
        
        
        
        
        
        
    }
    
    
}