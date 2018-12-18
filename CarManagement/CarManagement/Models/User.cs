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
   public  class User
    {
        public User()
        {
            Password = "123456";
            Deleted = false;
            LastLoginDateTime = DateTime.UtcNow;
        }


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }


        public string Name { get; set; }
        public string Password { get; set; }
        public virtual DateTime LastLoginDateTime { set; get; }
   
        public string CellPhone { get; set; }
        public string MelliCode { get; set; }
        public bool Deleted { get; set; }


        public IList<UserActivity> UserActivities { set; get; }


     
        public IList<UserVahedRole> UserVahedRoles { get; set; }
    }
}
