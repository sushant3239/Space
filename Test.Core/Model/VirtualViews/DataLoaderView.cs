using Test.Core.ViewModel;

namespace Test.Core.Model.VirtualViews
{
    public class DataLoaderView : VirtualView
    {
        protected new DataLoaderViewModel ViewModel
        {
            get { return base.ViewModel as DataLoaderViewModel; }
            set
            {
                base.ViewModel = value;
                RegisterViewModelPropertyChanged();
            }
        }

        private void RegisterViewModelPropertyChanged()
        {
            ViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "Loading") OnLoadDataComplete();
            };
        }

        protected virtual void OnLoadDataComplete() { }
    }
}
