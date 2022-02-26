using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using TradingApp.Models;
using TradingApp.ViewModels;
using System.Timers;
using System.Windows.Input;
using Newtonsoft.Json;
using TradingApp.Views;
using Timer = System.Threading.Timer;

namespace TradingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
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
        
        
        public MainWindow()
        {
           
           // CryptoInfoViewModel v = new CryptoInfoViewModel(this); 
            
            

           // NewsCryptoViewModel n = new NewsCryptoViewModel(this);

            //GraphicsViewModel grap = new GraphicsViewModel(this);
           
            //DataGrid1.ItemsSource = from t in v.DataCrypto select new{t.FROMSYMBOL, t.PRICE,t.LASTVOLUME, t.MKTCAP};
            LoadDataFromApiAtStart2(url);
            InitializeComponent();
           

            
            //t.Dispose();
        }   

        

        public void buttonMyPortfolio(object sender, RoutedEventArgs e)
        {
            DataContext = new UserPortfolioViewModel();
        }
        
        public void buttonMyCryptoList(object sender, RoutedEventArgs e)
        {
            DataContext = new UserCryptoListViewModel();
        }
        
        public void buttonGraphics(object sender, RoutedEventArgs e)
        {
            DataContext = new GraphicsViewModel();
        }
        
        public void buttonNews(object sender, RoutedEventArgs e)
        {
            DataContext = new NewsCryptoViewModel();
        }
        
        public void buttonHome(object sender, RoutedEventArgs e)
        {
            DataContext = new CryptoInfoViewModel();
        }

            private void Row_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {                
            // Ensure row was clicked and not empty space
            var row = ItemsControl.ContainerFromElement((DataGrid)sender,e.OriginalSource as DependencyObject ?? throw new InvalidOperationException()) as DataGridRow;

            if ( row == null ) return;

                
        }
    }
}