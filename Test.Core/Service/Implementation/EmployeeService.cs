using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Core.Model;
using Test.Core.Service.Interface;

namespace Test.Core.Service.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            await Task.Delay(3000);
            return new List<Employee>
            {
                new Employee { EmployeeName = "Employee 1" },
                new Employee { EmployeeName = "Employee 2" },
                new Employee { EmployeeName = "Employee 3" },
                new Employee { EmployeeName = "Employee 4" },
                new Employee { EmployeeName = "Employee 5" },
                new Employee { EmployeeName = "Employee 6" },
                new Employee { EmployeeName = "Employee 7" },
                new Employee { EmployeeName = "Employee 8" },
                new Employee { EmployeeName = "Employee 9" },
            };
        }
    }
}
