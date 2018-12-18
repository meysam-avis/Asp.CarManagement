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
    public class Avarez
    {
        [BsonId]
        public ObjectId Id { get; set; }
        
       // public int CarId { get; set; }
        public long Price { get; set; }
        public string Tarikh { get; set; }
        public string Rahgiri { get; set; }
        public string AvarezType { get; set; }
        public bool Deleted { get; set; }
       
        public string CarId { get; set; }
    }
}
