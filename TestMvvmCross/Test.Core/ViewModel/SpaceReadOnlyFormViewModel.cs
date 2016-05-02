using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Test.Core.Model;
using Test.Core.Service;

namespace Test.Core.ViewModel
{
    public class SpaceReadOnlyFormViewModel : MvxViewModel
    {
        private readonly IEmployeeService _employeeService;

        public SpaceReadOnlyFormViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            Employees = _employeeService.GetEmployees().ToList();
        }

        public List<Employee> Employees { get; set; }
    }
}
