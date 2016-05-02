using System.Collections.Generic;
using Test.Core.Model;

namespace Test.Core.Service
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
    }
}
