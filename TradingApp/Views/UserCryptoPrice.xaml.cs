using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;
using TradingApp.Models;

namespace TradingApp.Views
{
    public partial class UserCryptoPrice : UserControl
    {
        
        private string url = "https://min-api.cryptocompare.com/data/top/totalvolfull?limit=100&tsym=USD";

        public string URL
        {
            get => url;
        }
      
        private USD usdObj = new USD();
       


       





        
      
    
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
                        CryptoInfo myDeserializedClass = Deserializer(s);
                        foreach (var t in myDeserializedClass.Data)
                        {
                            l.Add(t.RAW.USD);
                        }




                            DataGrid1.ItemsSource =
                            from t in l select new {t.FROMSYMBOL, t.PRICE, t.LASTVOLUME, t.MKTCAP};

                    }


                    catch (Exception e)
                    {
                        Console.WriteLine("Warning " + e);
                    }


                
            }

        }

        
        
        
        
        
        
        
        public ObservableCollection<USD>  LoadDataFromApiAtStart(object url)
        {
            string myurl = (string) url;
            Scrapping scrap = new Scrapping();

            ObservableCollection<USD> l = new ObservableCollection<USD>();
           
            using (var web = new WebClient())
            {
                
                try
                {
                    web.Headers.Add("Apikey", scrap.KEY);

                    web.DownloadStringCompleted += (sender, args) =>
                    {
                        if (args.Cancelled || args.Error != null)
                        {
                            MessageBox.Show("Error");
                            return;
                        }

                      
                        string result = args.Result;
                        
                        
                        CryptoInfo myDeserializedClass =  Deserializer(result);
                        
                        
                        foreach (var t in myDeserializedClass.Data)
                        {
                            l.Add(t.RAW.USD);
                            //MessageBox.Show("the price "+t.RAW.USD.PRICE);
                        }

                       // _mainWindow.DataGrid1.ItemsSource = from t in l select new{t.FROMSYMBOL, t.PRICE,t.LASTVOLUME, t.MKTCAP};


                    };
                    
                     web.DownloadStringTaskAsync((new Uri(myurl)));
                    
                }

                catch (Exception e)
                {
                    Console.WriteLine("Warning " + e);
                }
            }


            return l;



        }

     

        public CryptoInfo Deserializer(string result)
        {
            CryptoInfo deserializeClass =  JsonConvert.DeserializeObject<CryptoInfo>(result);

            return deserializeClass;
        }
        
        public UserCryptoPrice()
        {
            LoadDataFromApiAtStart2(url);
            InitializeComponent();
        }
    }
}