using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DAL_Products
    {
        databaseDataContext db = new databaseDataContext();
        public List<Product> LoadProducts()
        {
            return db.Products.ToList();
        }
       
       
    }
}
