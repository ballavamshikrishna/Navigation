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
    internal class HomeViewModel: ViewModelBase
    {
        private readonly NavigationStore navigationStore;
        public ICommand ViewAccountCommand { get; set; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            ViewAccountCommand = new NavigateCommand<AccountViewModel>(this.navigationStore, () => new AccountViewModel(this.navigationStore));
        }
    }

   
}
