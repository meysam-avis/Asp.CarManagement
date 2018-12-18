using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace ViewModels
{
  public  class BimehViewModel
    {
      
        public int Id { get; set; }
        public string StrType { get; set; }

        public string Name { get; set; }
        public string Shomareh { get; set; }
        public string TarikhSodour { get; set; }
        public string  TarikhEngheza { get; set; }
       public long Price { get; set; }
        public string Pelak { get; set; }
        public BimehType Type { get; set; }
      

    }
}
