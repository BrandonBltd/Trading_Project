using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace TradingApp.Models
{
    public class SourceInfo
    {
        public string name { get; set; }
        public string lang { get; set; }
        public string img { get; set; }
    }

    public  class Data
    {
        public string id { get; set; }
        public string guid { get; set; }
        public int published_on { get; set; }
        public string imageurl { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string source { get; set; }
        public string body { get; set; }
        public string tags { get; set; }
        public string categories { get; set; }
        public string upvotes { get; set; }
        public string downvotes { get; set; }
        public string lang { get; set; }
        public SourceInfo source_info { get; set; }
    }

   

    public class NewsOncrypto
    {

        private string url = "https://min-api.cryptocompare.com/data/v2/news/?lang=EN";
      
        public List<Data> Data { get; set; }
        
        
       
        
      
    }
}