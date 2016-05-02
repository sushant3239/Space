﻿using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsCommon.Views;
using Test.Core;
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
            if (request.ViewModelType != typeof(SpaceViewModel))
            {
                _rootFrame.Navigate(typeof(MainView), null);
                return;
            }
            _rootFrame.Navigate(typeof(SpacePage), null);
        }
    }
}
