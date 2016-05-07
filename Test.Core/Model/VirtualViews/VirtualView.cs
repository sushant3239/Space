using Cirrious.MvvmCross.ViewModels;
using System.Collections.ObjectModel;

namespace Test.Core.Model.VirtualViews
{
    public abstract class VirtualView : MvxViewModel
    {
        private MvxViewModel _viewModel;
        private ObservableCollection<ViewField<string>> _fields;

        public ObservableCollection<ViewField<string>> Fields
        {
            get { return _fields; }
            set
            {
                _fields = value;
                RaiseAllPropertiesChanged();
            }
        }

        protected MvxViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                OnViewModelSet();
            }
        }

        public virtual void OnViewModelSet() { }
    }
}
