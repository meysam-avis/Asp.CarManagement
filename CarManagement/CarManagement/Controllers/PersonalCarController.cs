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
   public  class PersonalCarController
    {


        public void Create(PersonalCar t)
        {
            using (var db = new CarManagementDB())
            {

                db.PersonalCars.Add(t);

                db.SaveChanges();
            }
        }

        public List<PersonalCar> GetAll()
        {
            using (var db = new CarManagementDB())
            {
                return db.PersonalCars.
                    Include(p => p.Car).
                    Include(p => p.Driver).
                    Include(p => p.User).
                    Where(p => !p.Deleted).ToList();
            }
        }
        public List<PersonalCarViewModel> GetAllDGV()
        {
            using (var db = new CarManagementDB())
            {
                return db.PersonalCars.Where(p => !p.Deleted && !p.Finished).Include(p => p.Driver).Include(p => p.Car).Select(p => new PersonalCarViewModel
                {

                    Id = p.Id,
                    ShomareNameh = p.ShomareNameh,
                    CarName = p.Car.Name,
                    CarPelak = p.Car.Pelak,
                    DriverName = p.Driver.Name,
                    TarikhBargasht = p.TarikhBargasht,
                    TarikhRaft = p.TarikhRaft,
                  

                }).ToList();

            }
        }

        public void Delete(int id)
        {

            using (var db = new CarManagementDB())
            {
                var m = db.PersonalCars.Find(id);
                m.Deleted = true;
                db.SaveChanges();
            }



        }

        public List<PersonalCar> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonalCar t)
        {
            using (var db = new CarManagementDB())
            {
                var m = db.PersonalCars.Find(t.Id);
               
                m.CarId = t.CarId;
                m.DriverId = t.DriverId;
                m.KilometerBargasht = t.KilometerBargasht;
                m.KilometerRaft = t.KilometerRaft;
                m.Finished = t.Finished;

                m.ShomareNameh = t.ShomareNameh;
                m.TarikhBargasht = t.TarikhBargasht;
                m.TarikhRaft = t.TarikhRaft;
               
                db.SaveChanges();
            }
        }

        public PersonalCar Get(int id)
        {
            using (var db = new CarManagementDB())
            {
                return db.PersonalCars.Include(p => p.Driver).Include(p => p.Car).Include(p => p.User)
                    .SingleOrDefault(p => p.Id == id);

            }
        }

        public void EndMamoriat(int id)
        {
            using (var db = new CarManagementDB())
            {
                var m = db.PersonalCars.Find(id);
                if (m != null) m.Finished = true;

                db.SaveChanges();
            }

        }







    }
}
