using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Windows.Input;
using System;

namespace Test.Core
{
    public class SpaceForm1ViewModel : MvxViewModel
    {
        public SpaceForm1ViewModel()
        {
            TestData = new SpaceForm1Model();
        }

        public SpaceForm1Model TestData { get; set; }

        public ICommand SubmitCommand { get { return new MvxCommand(SubmitData); } }

        private void SubmitData()
        {
        }
    }

    public class SpaceForm1Model : MvxNotifyPropertyChanged
    {
        private string _string1;
        public string String1
        {
            get { return _string1; }
            set
            {
                _string1 = value;
                RaisePropertyChanged();
            }
        }
        private string _string2;
        public string String2
        {
            get { return _string2; }
            set
            {
                _string2 = value;
                RaisePropertyChanged();
            }
        }

        private string _string3;
        public string String3
        {
            get { return _string3; }
            set
            {
                _string3 = value;
                RaisePropertyChanged();
            }
        }

        private string _string4;
        public string String4
        {
            get { return _string4; }
            set
            {
                _string4 = value;
                RaisePropertyChanged();
            }
        }

        private string _string5;
        public string String5
        {
            get { return _string5; }
            set
            {
                _string5 = value;
                RaisePropertyChanged();
            }
        }
    }
}
