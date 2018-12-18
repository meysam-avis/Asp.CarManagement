using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ViewModels
{
    public class TasadofViewModel
    {
        public int Id { get; set; }
        public long Price { get; set; }
        public string Tarikh { get; set; }
        public string CarPelak { get; set; }
        public string DriverName { get; set; }

    }
}
