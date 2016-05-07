using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;

namespace Test.Core.ViewModel
{
    public class ViewModelLocator
    {
        public TViewModel ResolveViewModelAndLoadData<TViewModel>() where TViewModel : DataLoaderViewModel
        {
            var viewModel = Mvx.IocConstruct<TViewModel>();
            viewModel.Load();
            return viewModel;
        }

        public TViewModel ResolveViewModel<TViewModel>() where TViewModel : MvxViewModel
        {
            return Mvx.IocConstruct<TViewModel>();
        }
    }
}
