using CRUD_WebApplication.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD_WebApplication.Data
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int id);
    }
}
