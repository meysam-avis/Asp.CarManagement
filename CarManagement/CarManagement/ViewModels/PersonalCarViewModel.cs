using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class PersonalCarViewModel
    {

        public int Id { get; set; }
        public int CarId { get; set; }
        public int DriverId { get; set; }
        public int UserId { get; set; }
        public string ShomareNameh { get; set; }
        public string Mabda { get; set; }
        public string Maghsad { get; set; }
        public string TarikhRaft { get; set; }
        public string TarikhBargasht { get; set; }
        public string ZamanRaft { get; set; }
        public string ZamanBargasht { get; set; }
        public bool Deleted { get; set; } = false;
        //public string KilometerRaft { get; set; }
        //public string KilometerBargasht { get; set; }
        public string CarName { get; set; }
        public string CarPelak { get; set; }
        public string DriverName { get; set; }


    }
}
