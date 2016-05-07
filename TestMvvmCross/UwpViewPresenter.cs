using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsCommon.Views;
using Test.Core;
using Test.Core.ViewModel;
using TestMvvmCross.View;

namespace TestMvvmCross
{
    public class UwpViewPresenter : MvxWindowsViewPresenter
    {
        private IMvxWindowsFrame _rootFrame;

        public UwpViewPresenter(IMvxWindowsFrame rootFrame) : base(rootFrame)
        {
            _rootFrame = rootFrame;
        }

        public override void Show(MvxViewModelRequest request)
        {
            if (request.ViewModelType == typeof(EmployeeViewModel))
                _rootFrame.Navigate(typeof(SpacePage), null);
            else
                base.Show(request);
        }
    }
}
