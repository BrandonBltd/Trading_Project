using System.Collections.Generic;

namespace TradingApp.Models
{
   
    

    public class OHLC
    {
        public int time { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double open { get; set; }
        public double volumefrom { get; set; }
        public double volumeto { get; set; }
        public double close { get; set; }
        public string conversionType { get; set; }
        public string conversionSymbol { get; set; }
        public bool Aggregated { get; set; }
        public int TimeFrom { get; set; }
        public int TimeTo { get; set; }
        public List<OHLC> Data { get; set; }
    }

    public class Datagraph
    {
        public string Response { get; set; }
        public string Message { get; set; }
        public bool HasWarning { get; set; }
        public int Type { get; set; }
        
        public OHLC Data { get; set; }
    }
    
    
}