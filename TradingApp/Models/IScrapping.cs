namespace TradingApp.Models
{
    public interface IScrapping
    {
        void LoadDataFromApiAtStart(string url);
        
    }
}