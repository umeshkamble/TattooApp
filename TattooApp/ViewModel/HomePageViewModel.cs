using System.Collections.ObjectModel;
using TattooApp.Models;
using TattooApp.Services;
using TattooApp.ViewModel.Base;

namespace TattooApp.ViewModel
{
    public partial class HomePageViewModel : BaseViewModel
    {

        #region Propery
        [ObservableProperty]
        ObservableCollection<Artists> artistList;

        [ObservableProperty]
        ObservableCollection<Artists> trendList;
        #endregion
        public HomePageViewModel()
        {
            ArtistList = new ObservableCollection<Artists>(ArtistService.Instance.GetArtists());
            TrendList = new ObservableCollection<Artists>(TrendService.Instance.GetTrends());
        }
    }
}

