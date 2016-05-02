using System;
using System.Collections.Generic;
using Test.Core.Model;

namespace Test.Core.Service
{
    public class EmployeeService : IEmployeeService
    {
        public IEnumerable<Employee> GetEmployees()
        {
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
