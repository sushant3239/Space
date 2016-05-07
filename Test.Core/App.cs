using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Test.Core.Service.Implementation;
using Test.Core.Service.Interface;
using Test.Core.ViewModel;

namespace Test.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            RegisterAppStart<MainViewModel>();

            Mvx.RegisterSingleton(() => new ViewModelLocator());
            Mvx.LazyConstructAndRegisterSingleton<ISpaceService, VirtualViewService>();
            Mvx.LazyConstructAndRegisterSingleton<IEmployeeService, EmployeeService>();
        }
    }
}
