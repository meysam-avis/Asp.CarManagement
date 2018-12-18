using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Car
    {
        public Car()
        {
            Deleted = false;
        }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }


        public string Name { get; set; }
        public string Pelak { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public bool Deleted { get; set; }
        public string Transferee { get; set; }


    }
}
