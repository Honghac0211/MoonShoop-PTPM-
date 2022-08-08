using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL__Employees
    {
        DAL__Employees dal_employees = new DAL__Employees();
        public List<Employee> LoadEmployees()
        {
            return dal_employees.LoadEmployees();
        }
    }
}
