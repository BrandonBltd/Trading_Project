using System.ComponentModel;
using System.Runtime.CompilerServices;
using TradingApp.Annotations;

namespace TradingApp.ViewModels
{
    public class BaseViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

      
        
    }
}