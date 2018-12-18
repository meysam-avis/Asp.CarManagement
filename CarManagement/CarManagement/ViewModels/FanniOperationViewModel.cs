using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class FanniOperationViewModel
    {
        public int Id { get; set; }
        public long Price { get; set; }
        public string Tarikh { get; set; }
        public string Description { get; set; }
        public string CarPelak { get; set; }
    }
}
