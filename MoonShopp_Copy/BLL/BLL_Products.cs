using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public class BLL_Products
    {
        DAL_Products dal_pro = new DAL_Products();
        //Load dữ liệu lên bảng
        public List<Product> LoadProducts()
        {
            return dal_pro.LoadProducts();
        }
        //load hình
       
    }
}
