using Navigation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.Store
{
    internal class NavigationStore
    {
        public event Action CurrentViewModelChanged;

        private ViewModelBase _viewModelBase;
        public ViewModelBase currentViewModel
        {
            get { return _viewModelBase; } 
            set
            {
                _viewModelBase = value;
                oncCurrentViewModelChanged();
            }
        }

        public NavigationStore()
        {
            //currentViewModel = new HomeViewModel(this);
        }

        protected virtual void oncCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
