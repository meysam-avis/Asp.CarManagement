using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;
using Car.ViewModels;


namespace Car.Controllers
{
  public   class FanniOperationController:IBaseDatabaseOperation<FanniOperation>
    {
        public void Create(FanniOperation t)
        {
            using (var db=new CarManagementDB())
            {
                db.FanniOperations.Add(t);
                db.SaveChanges();
            }
        }

        public List<FanniOperation> GetAll()
        {
            using (var db = new CarManagementDB())
            {
                return db.FanniOperations.ToList();
            }
        }

        public List<FanniOperationViewModel> GetAllForDGV()
        {
            using (var db = new CarManagementDB())
            {
                return db.FanniOperations.Include(p=>p.Car).Select(p=>new FanniOperationViewModel
                {
                    Id=p.Id,
                    CarPelak = p.Car.Pelak,
                    Description = p.Description,
                    Price = p.Price,
                    Tarikh = p.Tarikh 

                }).ToList();
            }
        }

        public void Delete(int id)
        {
            using (var db = new CarManagementDB())
            {
                var f = db.FanniOperations.Find(id);
                db.FanniOperations.Remove(f);
                db.SaveChanges();
            }
        }

        public List<FanniOperation> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(FanniOperation t)
        {
            using (var db = new CarManagementDB())
            {
                var f = db.FanniOperations.Find(t.Id);
                f.CarId = t.CarId;
                f.Description = t.Description;
                f.Price = t.Price;
                f.Tarikh = t.Tarikh;
                db.SaveChanges();
            }

        }

        public FanniOperation Get(int id)
        {
            using (var db=new CarManagementDB())
            {
                return db.FanniOperations.Include(p => p.Car).SingleOrDefault(p => p.Id == id);

            }
        }
    }
}
