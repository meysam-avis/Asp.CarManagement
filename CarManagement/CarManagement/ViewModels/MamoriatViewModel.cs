using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ViewModels
{
   public class MamoriatViewModel
    {
       
       
        public string CarName { get; set; }
        public string CarPelak { get; set; }
        public string DriverName { get; set; }

        public Mamoriat Mamoriat { get; set; }

        public virtual string UserName { get; set; }

        public string MabdaName { get; set; }


    }
}
