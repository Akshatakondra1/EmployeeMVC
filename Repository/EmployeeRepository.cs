using EmployeeMVC.Models;

namespace EmployeeMVC.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public static List<Employee> _Employees = new List<Employee>();
        static EmployeeRepository()
        {
            _Employees.Add(new Employee() { City = "nagpur", Id = 1, Name = "riay", Salary = 5424352 });
            _Employees.Add(new Employee() { City = "nagpur", Id = 2, Name = "shiya", Salary = 23332});
            _Employees.Add(new Employee() { City = "nagpur", Id = 3, Name = "tiya", Salary = 143235});
        
        }

        public void CreateEmployee(Employee employee)
        {
            _Employees.Add(employee);
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = _Employees.First(e => e.Id == id);
            _Employees.Remove(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            //USE LINQ
            Employee employee = _Employees.FirstOrDefault(e => e.Id == id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _Employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee emp = _Employees.First(e => e.Id == employee.Id);

            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.City = employee.City;
        }
    }
}
