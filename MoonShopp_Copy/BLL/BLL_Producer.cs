using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
   public class BLL_Producer
    {
        DAL_Producer dal_producer = new DAL_Producer();
        public List<Producer> LoadProducer()
        {
            return dal_producer.LoadProducer();
        }
    }
}
