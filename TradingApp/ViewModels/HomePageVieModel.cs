using System.Collections.Generic;
using System.Collections.ObjectModel;
using TradingApp.Models;

namespace TradingApp.ViewModels
{
    public class HomePageVieModel : BaseViewModels
    {


        public readonly ObservableCollection<USD> cryptoInfo;
        public IEnumerable<USD> CryptoInfo => cryptoInfo;
        private MainWindow _mainWindow;
        
        public HomePageVieModel(MainWindow mainWindow)
        {
            
            //cryptoInfo = new CryptoInfoViewModel().DataCrypto;
           

        }

    }
}