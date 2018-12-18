using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;

namespace Car.Controllers
{
   public  class DriverController:IBaseDatabaseOperation<Driver>
    {
        public void Create(Driver t)
        {

            using (var db = new CarManagementDB())
            {

                db.Drivers .Add(t);
                db.SaveChanges();
            }

        }

        public List<Driver> GetAll()
        {
            using (var db = new CarManagementDB())
            {
                return db.Drivers.Where(p => !p.Deleted).ToList();

            }
        }

        public void Delete(int id)
        {
            using (var db = new CarManagementDB())
            {
                var m = db.Drivers.Find(id);
                m.Deleted = true;
                db.SaveChanges();
            }

        }

        public List<Driver> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Driver t)
        {
            using (var db = new CarManagementDB())
            {
                var m = db.Drivers. Find(t.Id);
                m.CellPhone = t.CellPhone;
                m.MelliCode = t.MelliCode;
                m.Name = t.Name;
               

                db.SaveChanges();
            }
        }

        public Driver Get(int id)
        {
            using (var db = new CarManagementDB())
            {
                return db.Drivers.Find(id);

            }
        }
    }
}
