using EmployeeMVC.Data;
using EmployeeMVC.Models;

namespace EmployeeMVC.Repository
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {

        private readonly AppDbContext _context;

        public SqlEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

        }

        public void DeleteEmployee(int id)
        {
            Employee employee = _context.Employees.First(e => e.Id == id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee emp = _context.Employees.First(e => e.Id == employee.Id);

            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.City = employee.City;
        
           
            _context.SaveChanges();
        }
    }
}
