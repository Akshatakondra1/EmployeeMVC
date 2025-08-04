using EmployeeMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
