
using System;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsCommon.Views;
using Windows.UI.Xaml.Controls;

namespace TestMvvmCross
{
    public class Setup : Cirrious.MvvmCross.WindowsCommon.Platform.MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {

        }
        protected override IMvxApplication CreateApp()
        {
            return new Test.Core.App();
        }

        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            return new UwpViewPresenter(rootFrame);
        }
    }
}
