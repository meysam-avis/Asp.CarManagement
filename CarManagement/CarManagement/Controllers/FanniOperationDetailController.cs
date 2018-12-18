using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car.Models;

namespace Car.Controllers
{
    public class FanniOperationDetailController:IBaseDatabaseOperation<FanniOperationDetail>
    {
        public void Create(FanniOperationDetail t)
        {
            using (var db = new CarManagementDB())
            {
                db.FanniOperationDetails.Add(t);
                db.SaveChanges();
            }
        }

        public List<FanniOperationDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<FanniOperationDetail> Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(FanniOperationDetail t)
        {
            throw new NotImplementedException();
        }

        public FanniOperationDetail Get(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByOperationId(int fId)
        {
            using (var db=new CarManagementDB())
            {
                var op = db.FanniOperationDetails.Where(p => p.FanniOperationId == fId);
                db.FanniOperationDetails.RemoveRange(op);

                db.SaveChanges();
            }
        }

        public List<FanniOperationDetail> GetByOperationId(int id)
        {
            using (var db = new CarManagementDB())
            {
                return db.FanniOperationDetails.Where(p => p.FanniOperationId == id).ToList();
            }
        }
    }
}
