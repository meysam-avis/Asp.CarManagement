using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
   public class Role
    {
      public  Role()
        {
            Permission = "User";
            Deleted = false;
            Name = "کاربر";

        }
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { set; get; }
       
        public string Permission { set; get; }
        public bool Deleted { get; set; } 
    
        public IList<UserVahedRole> UserVahedRoles { get; set; }

        
    }
}
