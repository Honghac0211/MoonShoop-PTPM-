using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Carts
    {
        databaseDataContext db = new databaseDataContext();
        public List<Cart> LoadCarts()
        {
            return db.Carts.ToList();
        }
    }
}
