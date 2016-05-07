using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Core.Model;

namespace Test.Core.Service.Interface
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
