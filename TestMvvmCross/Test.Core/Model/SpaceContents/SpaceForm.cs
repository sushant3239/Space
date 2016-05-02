using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace Test.Core.Model
{
    public class SpaceForm : SpaceContent
    {
        public SpaceForm(string header, MvxViewModel viewModel)
            : base(header, viewModel)
        { }

        public new SpaceForm1ViewModel ViewModel
        {
            get { return base.ViewModel as SpaceForm1ViewModel; }
            set { base.ViewModel = value; }
        }

        public ICommand SubmitCommand { get { return new MvxCommand(OnSubmit); } }
        private void OnSubmit()
        {
            OnSubmit(SpaceFileds);
        }
        private void OnSubmit(IEnumerable<SpaceField<object>> fields) { }        
    }
}
