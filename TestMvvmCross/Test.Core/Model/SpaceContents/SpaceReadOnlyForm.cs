using System;
using Cirrious.MvvmCross.ViewModels;
using Test.Core.ViewModel;
using System.Collections.ObjectModel;

namespace Test.Core.Model
{
    public class SpaceReadOnlyForm : SpaceContent
    {
        public SpaceReadOnlyForm(string header, MvxViewModel viewModel)
            : base(header, viewModel)
        { InitFields(); }

        public new SpaceReadOnlyFormViewModel ViewModel
        {
            get { return base.ViewModel as SpaceReadOnlyFormViewModel; }
            set { base.ViewModel = value; }
        }


        private void InitFields()
        {
            SpaceFileds = new ObservableCollection<SpaceField<object>>();
            foreach (var employee in ViewModel.Employees)
            {
                SpaceFileds.Add(new SpaceField<object> { FieldValue = employee.EmployeeName, Label = "Name:", InputType = InputType.ReadOnly });
            }
        }
    }
}
