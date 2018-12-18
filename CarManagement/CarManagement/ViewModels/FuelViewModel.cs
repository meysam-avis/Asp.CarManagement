using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace ViewModels
{
   public  class FuelViewModel
    {
       
        public int Id { get; set; }
        public int CarId { get; set; }
        public string FuelType { set; get; }
        public int Kilometer { set; get; }
        public string FactorNumber { set; get; }
        public long Mablagh { set; get; }
        public string TarikhPardakht { set; get; }
        public bool Deleted { get; set; }
        public string CarName { get; set; }
        public string CarPelak { get; set; }
        public string CarColor { get; set; }
        public string CarModel { get; set; }
       




    }
}
