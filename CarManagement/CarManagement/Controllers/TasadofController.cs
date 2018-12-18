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
   public  class TasadofController:IBaseDatabaseOperation<Tasadof>
    {
        public void Create(Tasadof t)
        {
            using (var db = new CarManagementDB())
            {
                db.Tasadofat.Add(t);
                db.SaveChanges();
            }
        }

        public List<Tasadof> GetAll()
        {
            throw new NotImplementedException();
        }
        
        public List<TasadofViewModel> GetAllForDGV()
        {
            using (var db = new CarManagementDB())
            {

                return db.Tasadofat.Include(p => p.Car).Include(p => p.Driver)
                    .Select(p => new TasadofViewModel
                    {
                        Id=p.Id,
                        CarPelak = p.Car.Pelak,
                        DriverName = p.Driver.Name,
                        Price = p.Price,
                        Tarikh = p.Tarikh
                    }).ToList();

            }
        }
        public void Delete(int id)
        {
            using (var db = new CarManagementDB())
            {
                var a = db.Tasadofat.Find(id);
                db.Tasadofat.Remove(a);
                db.SaveChanges();
            }
        }

        public List<Tasadof> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Tasadof t)
        {
            using (var db = new CarManagementDB())
            {
                var m = db.Tasadofat.Find(t.Id);
                m.CarId = t.CarId;
                m.DriverId = t.DriverId;
                m.Price = t.Price;
                m.Tarikh = t.Tarikh;
                
                db.SaveChanges();
            }
        }

        public Tasadof Get(int id)
        {
            using (var db = new CarManagementDB())
            {

                return db.Tasadofat.Find(id);

            }
        }
    }
}
