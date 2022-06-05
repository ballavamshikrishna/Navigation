using Navigation.Command;
using Navigation.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation.ViewModel
{
    internal class AccountViewModel: ViewModelBase
    {
        private readonly NavigationStore navigationStore;
        public ICommand viewHomeCommand { get; set; }
        public AccountViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            viewHomeCommand = new NavigateCommand<HomeViewModel>(this.navigationStore, () =>  new HomeViewModel(this.navigationStore));
        }
    }
}
