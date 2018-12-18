using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;

namespace Car.Controllers
{
   public  class FanniController:IBaseDatabaseOperation<Fanni>
    {
        public void Create(Fanni t)
        {
            throw new NotImplementedException();
        }

        public List<Fanni> GetAll()
        {
            using (var db = new CarManagementDB())
            {
                return db.FanniDbSet.ToList();

            }

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Fanni> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Fanni t)
        {
            throw new NotImplementedException();
        }

        public Fanni Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
