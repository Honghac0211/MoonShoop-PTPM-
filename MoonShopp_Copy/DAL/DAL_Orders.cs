using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Orders
    {
        databaseDataContext db = new databaseDataContext();
        public List<Order> LoadOrders()
        {
            return db.Orders.ToList();
        }
    }
}
