using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace ViewModels
{
   public  class AvarezViewModel
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public long Price { get; set; }
        public string Tarikh { get; set; }
        public string Rahgiri { get; set; }
        public string strAvarezType { get; set; }
        public short shrAvarezType { get; set; }
        public string Pelak { get; set; }


    }
}
