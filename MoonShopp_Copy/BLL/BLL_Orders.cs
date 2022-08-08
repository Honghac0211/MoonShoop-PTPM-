using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_Orders
    {
        DAL_Orders dal_orders = new DAL_Orders();
        public List<Order> LoadOrders()
        {
            return dal_orders.LoadOrders();
        }
    }
        
}
