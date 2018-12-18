using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tasadof
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CarId { get; set; }
        public int DriverId { get; set; }
        public long Price { get; set; }
        public string Tarikh { get; set; }
        [ForeignKey("CarId")]
        public Car Car { set; get; }
        [ForeignKey("DriverId")]
        public Person Driver { set; get; }
        public bool Deleted { get; set; }


    }
}
