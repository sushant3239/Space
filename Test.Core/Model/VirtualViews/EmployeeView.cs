using Cirrious.CrossCore;
using System.Collections.ObjectModel;
using Test.Core.ViewModel;

namespace Test.Core.Model.VirtualViews
{
    public class EmployeeView : DataLoaderView
    {
        public EmployeeView()
        {
            ViewModel = Mvx.Resolve<ViewModelLocator>().ResolveViewModelAndLoadData<EmployeeViewModel>();
        }

        protected new EmployeeViewModel ViewModel
        {
            get { return base.ViewModel as EmployeeViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnLoadDataComplete()
        {
            var fields = new ObservableCollection<ViewField<string>>();

            foreach (var employee in ViewModel.Employees)
            {
                var field = new ViewField<string>
                {
                    FieldLable = "Name : ",
                    FieldValue = employee.EmployeeName,
                    InputType = InputType.ReadOnly,
                };
                fields.Add(field);
            }
            Fields = fields;
        }
    }
}
