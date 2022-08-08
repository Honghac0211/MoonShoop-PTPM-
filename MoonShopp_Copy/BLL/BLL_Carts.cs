using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLL_Carts
    {
        DAL_Carts dal_orders = new DAL_Carts();
        public List<Cart> LoadCarts()
        {
            return dal_orders.LoadCarts();
        }
    }
}
