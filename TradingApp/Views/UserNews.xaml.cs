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
    public partial class UserNews : UserControl
    {
        private MainWindow _mainWindow;

        private string url = "https://min-api.cryptocompare.com/data/v2/news/?lang=EN";
        
        
        
        public async void LoadDataFromApiAtStart2(string url)
        {


            Scrapping scrap = new Scrapping();

            var l = new ObservableCollection<Data>();

            using (var web = new WebClient())
            {

                try
                {
                    web.Headers.Add("Apikey", scrap.KEY);
                    var s = await web.DownloadStringTaskAsync((new Uri(url)));
                    NewsOncrypto myDeserializedClass = Deserializer(s);
                    foreach (var t in myDeserializedClass.Data)
                    {
                        l.Add(t);
                    }




                    ListView1.ItemsSource =
                        from t in l select new {t.imageurl, t.title, t.body};

                }


                catch (Exception e)
                {
                    Console.WriteLine("Warning " + e);
                }


            }
        }
        
        public NewsOncrypto Deserializer(string result)
        {
            NewsOncrypto deserializeClass =  JsonConvert.DeserializeObject<NewsOncrypto>(result);

            return deserializeClass;
        }
        public UserNews()
        {
            LoadDataFromApiAtStart2(url);
            InitializeComponent();
        }
    }
}