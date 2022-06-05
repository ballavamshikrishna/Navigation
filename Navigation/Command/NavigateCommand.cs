using Navigation.Store;
using Navigation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.Command
{
    internal class NavigateCommand<TViewModel>: CommandBase
        where TViewModel : ViewModelBase
    {
        private readonly NavigationStore navigationStore;
        private readonly Func<TViewModel> createViewModel;
        public NavigateCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            this.navigationStore = navigationStore;
            this.createViewModel = createViewModel;
        }

        public override void Execute(object? parameter)
        {
            navigationStore.currentViewModel = createViewModel();
        }
    }
}
