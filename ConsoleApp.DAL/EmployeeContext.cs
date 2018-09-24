using System.Data.Entity;
using ConsoleApp.Model;

namespace ConsoleApp.DAL
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeContext()
        {

        }

        public EmployeeContext(string connectionString) : base(connectionString)
        {

        }
    }
}
