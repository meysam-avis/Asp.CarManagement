using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Infrastructure;
using Car.Models;
using Car.ViewModels;

namespace Car.Controllers
{
  public   class FuelController:IBaseDatabaseOperation<Fuel>
    {
        public void Create(Fuel t)
        {
            using (var db = new CarManagementDB())
            {
                db.Fuels.Add(t);
                db.SaveChanges();
            }

        }

        public List<Fuel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            using (var db = new CarManagementDB())
            {
                var m = db.Fuels.Find(id);
                m.Deleted = true;
                db.SaveChanges();
            }
        }

        public List<Fuel> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Fuel t)
        {


            using (var db = new CarManagementDB())
            {
                var a = db.Fuels .Find(t.Id);
                a.CarId = t.CarId;
                a.FactorNumber = t.FactorNumber;
                a.Kilometer = t.Kilometer;
                a.Mablagh = t.Mablagh;
                a.FuelTypeId = t.FuelTypeId;
                a.TarikhPardakht = t.TarikhPardakht;
              
                db.SaveChanges();

            }
        }

        public Fuel Get(int id)
        {
            using (var db = new CarManagementDB())
            {
                return db.Fuels .Include(p => p.Car).Include(p => p.FuelType)
                    .SingleOrDefault(p => p.Id == id);


            }
        }

        public List<FuelViewModel> GetAllDGV()
        {

           using (var db = new CarManagementDB())
            {
                return db.Fuels.Where(p => !p.Deleted).Include(p => p.Car).Include(p=>p.FuelType ).Select(p => new FuelViewModel
                {

                    Id = p.Id,
                    FuelType = p.FuelType .Name ,
                    CarColor = p.Car.Color,
                    CarModel = p.Car.Model,
                    CarName = p.Car.Name,
                    CarPelak = p.Car.Pelak,
                    Kilometer = p.Kilometer,
                    FactorNumber = p.FactorNumber,
                    Mablagh = p.Mablagh,
                    TarikhPardakht = p.TarikhPardakht

                }).ToList();


            }

       

        }
    }
}
