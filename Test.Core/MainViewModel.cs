
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;
using Test.Core.ViewModel;

namespace Test.Core
{
    public class MainViewModel : MvxViewModel
    {
        public ICommand NavigateToEmployeeViewModel
        {
            get { return new MvxCommand( () => { ShowViewModel<EmployeeViewModel>(); }); }
        }
    }
}
