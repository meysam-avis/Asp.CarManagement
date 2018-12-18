using Infrastructure;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Bimeh
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Shomareh { get; set; }
        public string TarikhSodour { get; set; }
        public string TarikhEngheza { get; set; }
        public long Price { get; set; }
        public BimehType Type { get; set; }
        public bool Deleted { get; set; }
        public string  CarId { set; get; }

    }
}
