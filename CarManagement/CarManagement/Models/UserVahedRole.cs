using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class UserVahedRole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }
        public int RoleId { get; set; }
      
        public int VahedId { get; set; }



        [ForeignKey("UserId")]
        public User User { get; set; }


        [ForeignKey("RoleId")]
        public Role Role { get; set; }


        [ForeignKey("VahedId")]
        public Vahed Vahed { get; set; }

    }
}
