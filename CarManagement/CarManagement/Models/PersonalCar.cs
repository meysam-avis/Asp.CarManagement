using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Models
{
   public  class PersonalCar
    {

        [BsonId]
        public ObjectId Id { get; set; }


     
        public string ShomareNameh { get; set; }
        public string TarikhRaft { get; set; }
        public string TarikhBargasht { get; set; }
        public int KilometerRaft { get; set; }
        public int KilometerBargasht { get; set; }
     
        public virtual Car Car { get; set; }

      
        public virtual User User { get; set; }
      
        public virtual Person Driver { get; set; }
       
        public bool Deleted { get; set; } = false;
        public virtual bool Finished { get; set; } = false;
    }
}
