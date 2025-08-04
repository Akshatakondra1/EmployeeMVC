using EmployeeMVC.Models;

namespace EmployeeMVC.Repository
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetEmployees();

        public Employee GetEmployeeById(int id);

        public void CreateEmployee(Employee employee);

        public void UpdateEmployee(Employee employee);

        public void DeleteEmployee(int id);
    }
}
