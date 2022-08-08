using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Customers
    {
        DAL_Customers dal_customers = new DAL_Customers();
        public List<Customer> LoadCustomers()
        {
            return dal_customers.LoadCustomers();
        }
    }
}
