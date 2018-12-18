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
    public class FuelType
    {
        [BsonId]
        public ObjectId Id { get; set; }



        public string Name { get; set; }
        public bool Deleted { get; set; } = false;
        public IList<Fuel> Fuels { get; set; }
    }
}
