using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Test.Core.Service;

namespace Test.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            RegisterAppStart<MainViewModel>();
            Mvx.LazyConstructAndRegisterSingleton<ISpaceService, SpaceService>();
            Mvx.LazyConstructAndRegisterSingleton<IEmployeeService, EmployeeService>();
        }
    }
}
