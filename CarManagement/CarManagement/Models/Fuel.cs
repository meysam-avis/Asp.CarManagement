using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
  public   class Fuel
    {

        [BsonId]
        public ObjectId Id { get; set; }


        public int Kilometer { set; get; }
        public string FactorNumber { set; get; }
        public long Mablagh { set; get; }
        public string TarikhPardakht { set; get; }
        public bool Deleted { get; set; }

      
        public Car Car { set; get; }

      
        public FuelType FuelType { get; set; }
    }
}
