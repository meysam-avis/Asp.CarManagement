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
   public  class Setting
    {
      public Setting()
      {
          PermitedDuration = 20;
          Locked = false;
      }

        [BsonId]
        public ObjectId Id { get; set; }


       
        public string LastVersion { set; get; }
        public bool Locked { set; get; } 
        public int PermitedDuration { set; get; }
        public string Year { set; get; }
    }
}
