using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Producer
    {
        databaseDataContext db = new databaseDataContext();
        public List<Producer> LoadProducer()
        {
            return db.Producers.ToList();
        }
    }
}
