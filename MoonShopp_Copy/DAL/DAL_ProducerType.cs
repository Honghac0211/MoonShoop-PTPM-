using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ProducerType
    {
        databaseDataContext db = new databaseDataContext();
        public List<ProducerType> LoadOProducerType()
        {
            return db.ProducerTypes.ToList();
        }
    }
}
