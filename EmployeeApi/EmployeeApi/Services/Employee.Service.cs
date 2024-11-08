using EmployeeApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeApi.Services
{
    public class EmployeeService
    {
        private readonly EmployeeContext _context;

        public EmployeeService(EmployeeContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void RegisterEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}