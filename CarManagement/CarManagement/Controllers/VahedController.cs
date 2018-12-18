using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;
using NobatTaeenTaklif.Models;

namespace Car.Controllers
{
   public  class VahedController:IBaseDatabaseOperation<Vahed>
    {
        public void Create(Vahed t)
        {
            throw new NotImplementedException();
        }

        public List<Vahed> GetAll()
        {
            using (var db = new CarManagementDB())
            {
                return db.Vahedha.Where(p => !p.Deleted).ToList();

            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Vahed> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Vahed t)
        {
            throw new NotImplementedException();
        }

        public Vahed Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
