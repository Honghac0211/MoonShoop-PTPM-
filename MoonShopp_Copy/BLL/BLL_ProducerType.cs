using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_ProducerTypes
    {
        databaseDataContext db = new databaseDataContext();
        public List<ProducerType> LoadOProducerType()
        {
            return db.ProducerTypes.ToList();
        }
    }
}
