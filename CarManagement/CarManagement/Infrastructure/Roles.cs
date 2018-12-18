using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Roles
    {
      
        public string Value { get; set; }

        public static string NormalUser { get; } = "user";

        public static string Admin { get; } = "admin";

        public static string SuperAdmin { get; } = "superAdmin";

     

    }
}
