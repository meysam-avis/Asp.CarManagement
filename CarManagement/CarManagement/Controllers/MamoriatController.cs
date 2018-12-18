using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;
using Car.ViewModels;
using Car.Views;

namespace Car.Controllers
{
    public class MamoriatController : IBaseDatabaseOperation<Mamoriat>
    {
        public void Create(Mamoriat t)
        {
            using (var db = new CarManagementDB())
            {

                db.Mamoriatha.Add(t);

                db.SaveChanges();
            }
        }

        public List<Mamoriat> GetAll()
        {
            using (var db = new CarManagementDB())
            {
                return db.Mamoriatha.
                    Include(p => p.Car).
                    Include(p => p.Driver).
                    Include(p => p.User).
                    Where(p => !p.Deleted).ToList();
             }
        }
        public List<MamoriatViewModel> GetAllDGV()
        {
            using (var db = new CarManagementDB())
            {
                return db.Mamoriatha.Where(p => !p.Deleted && ! p.Finished).Include(p => p.Driver).Include(p => p.Car).Select(p => new MamoriatViewModel
                {

                    Id = p.Id,
                    ShomareNameh = p.ShomareNameh,
                    CarName = p.Car.Name,
                    CarPelak = p.Car.Pelak,
                    DriverName = p.Driver.Name,
                    Mabda = p.Mabda,
                    Maghsad = p.Maghsad,
                    TarikhBargasht = p.TarikhBargasht,
                    TarikhRaft = p.TarikhRaft,
                    ZamanBargasht = p.ZamanBargasht,
                    ZamanRaft = p.ZamanRaft

                }).ToList();

            }
        }

        public void Delete(int id)
        {

            using (var db = new CarManagementDB())
            {
                var m = db.Mamoriatha.Find(id);
                m.Deleted = true;
                db.SaveChanges();
            }



        }

        public List<Mamoriat> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Mamoriat t)
        {
            using (var db = new CarManagementDB())
            {
                var m = db.Mamoriatha .Find(t.Id);
                m.Mabda = t.Mabda;
                m.CarId = t.CarId;
                m.DriverId = t.DriverId;
                m.Maghsad = t.Maghsad;
                m.ShomareNameh = t.ShomareNameh;
                m.TarikhBargasht = t.TarikhBargasht;
                m.TarikhRaft = t.TarikhRaft;
                m.KilometerBargasht = t.KilometerBargasht;
                m.KilometerRaft = t.KilometerRaft;
                m.Finished = t.Finished;

                m.ZamanBargasht = t.ZamanBargasht;
                m.ZamanRaft = t.ZamanRaft;
             
                db.SaveChanges();
            }
        }

        public Mamoriat Get(int id)
        {
            using (var db = new CarManagementDB())
            {
                return db.Mamoriatha.Include(p => p.Driver).Include(p => p.Car).Include(p => p.User)
                    .SingleOrDefault(p => p.Id == id);

            }
        }

      
    }
}
