
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace Test.Core
{
    public class MainViewModel : MvxViewModel
    {
        public ICommand NavigateToSpaceViewCommand
        {
            get { return new MvxCommand( () => { ShowViewModel<SpaceViewModel>(); }); }
        }
    }
}
