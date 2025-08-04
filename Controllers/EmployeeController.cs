using EmployeeMVC.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeMVC.Models;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            List<Employee> lstemployee = _employeeRepository.GetEmployees();
            return View(lstemployee);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            return View(employee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee collection)
        {
            try
            {
                _employeeRepository.CreateEmployee(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee collection)
        {
            try
            {
                _employeeRepository.UpdateEmployee(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            return View(employee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee collection)
        {
            try
            {
                _employeeRepository.DeleteEmployee(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
