using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;


namespace Models
{
  public  class UserActivity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
       
        public string IP { get; set; }

      
        public UserActivityType UserActivityType { set; get; }
        public DateTime ActivityDate { set; get; } = DateTime.UtcNow;
        public string Description { get; set; }


        [ForeignKey("UserId")]
        public User User { set; get; }
    }
}
