using Navigation.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.ViewModel
{
    internal class MainViewModel: ViewModelBase
    {
        public ViewModelBase currentViewModel => navigationStore.currentViewModel;

        private  NavigationStore navigationStore { get; set; }
        public MainViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            this.navigationStore.CurrentViewModelChanged += NavigationStore_CurrentViewModelChanged;
        }

        private void NavigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged("currentViewModel");
        }
    }
}
