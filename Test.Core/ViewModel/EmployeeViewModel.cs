using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Core.Model;
using Test.Core.Service;
using Test.Core.Service.Interface;

namespace Test.Core.ViewModel
{
    public class EmployeeViewModel : DataLoaderViewModel
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeViewModel(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        protected async override Task LoadData()
        {
            var employees = await _employeeService.GetEmployees();
            Employees = new List<Employee>(employees);
        }

        public List<Employee> Employees { get; set; }
    }
}
