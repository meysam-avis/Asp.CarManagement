using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ViewModels
{
   public  class CarViewModel
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }


        public string Name { get; set; }

        public string Pelak { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public bool Deleted { get; set; }
        public string Transferee { get; set; }

        public string TransfereeName { get; set; }

    }
}
