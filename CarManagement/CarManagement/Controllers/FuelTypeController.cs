using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;

namespace Car.Controllers
{
  public   class FuelTypeController:IBaseDatabaseOperation<FuelType >
    {
        public void Create(FuelType t)
        {
            throw new NotImplementedException();
        }

        public List<FuelType> GetAll()
        {
            using (var db = new CarManagementDB())
            {
                return db.FuelTypes.
                  Where(p => !p.Deleted).ToList();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<FuelType> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(FuelType t)
        {
            throw new NotImplementedException();
        }

        public FuelType Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
