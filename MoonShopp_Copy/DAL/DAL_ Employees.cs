using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL__Employees
    {
        databaseDataContext db = new databaseDataContext();
        public List<Employee> LoadEmployees()
        {
            return db.Employees.ToList();
        }
    }
}
