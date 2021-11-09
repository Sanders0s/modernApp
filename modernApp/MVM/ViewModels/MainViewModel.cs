using GalaSoft.MvvmLight.Messaging;
using Microsoft.VisualStudio.OLE.Interop;
using modernApp.Core;
using modernApp.MVM.Model;
using modernApp.MVM.ViewModels;
using System.Windows;

namespace modernApp.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private object _currentView;
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand AdditionalViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        public AdditionalViewModel AdditionalVM { get; set; }
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            AdditionalVM = new AdditionalViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });

            AdditionalViewCommand = new RelayCommand(o =>
            {
                CurrentView = AdditionalVM;
            });
        }
    }
}