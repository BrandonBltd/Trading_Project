using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows;
using Newtonsoft.Json;
using SciChart.Charting.Model.DataSeries;
using SciChart.Core.Extensions;
using ScottPlot;
using TradingApp.Models;


namespace TradingApp.ViewModels
{
    public class GraphicsViewModel : BaseViewModels
    {
        /*private MainWindow _mainWindow;
        private Graphics g;

        private string url = "https://min-api.cryptocompare.com/data/v2/histominute?fsym=BTC&tsym=GBP&limit=10";

        public GraphicsViewModel(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            
            LoadDataFromApiAtStart2(url);
            
        }
        
        public async void LoadDataFromApiAtStart2(string url)
        {

            
            Scrapping scrap = new Scrapping();

            var l = new ObservableCollection<USD>();
         
            
            using (var web = new WebClient())
            {
               
                try
                {
                    web.Headers.Add("Apikey", scrap.KEY);
                    var s = await web.DownloadStringTaskAsync((new Uri(url)));
                   Datagraph myDeserializedClass = Deserializer(s);
                  
                       
                  //data ohlc dans myDeserializeClass.Data.Data
                }


                catch (Exception e)
                {
                    Console.WriteLine("Warning " + e);
                }


                
            }

        }

       
        
        public Datagraph Deserializer(string result)
        {
            Datagraph deserializeClass =  JsonConvert.DeserializeObject<Datagraph>(result);

            return deserializeClass;
        }*/
        
        
    }
}