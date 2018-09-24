using System.Collections.Generic;
using System.Data.Entity.Migrations;
using ConsoleApp.Model;

namespace ConsoleApp.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext mContext;

        public EmployeeRepository(EmployeeContext context)
        {
            mContext = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return mContext.Employees.AsNoTracking();
        }

        public Employee GetById(int id)
        {
            return mContext.Employees.Find(id);
        }

        public void Add(Employee employee)
        {
            mContext.Employees.Add(employee);
            mContext.SaveChanges();
        }

        public void Edit(Employee employee)
        {
            mContext.Employees.AddOrUpdate(employee);
            mContext.SaveChanges();
        }

        public void Remove(Employee employee)
        {
            mContext.Employees.Remove(employee);
            mContext.SaveChanges();
        }
    }
}
