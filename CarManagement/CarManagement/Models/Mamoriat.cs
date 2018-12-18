using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Models
{
    public class Mamoriat
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ShomareNameh { get; set; }
        public string MabdaId { get; set; }
        public string Maghsad { get; set; }
        public string TarikhRaft { get; set; }
        public string TarikhBargasht { get; set; }

        public string ZamanRaft { get; set; }
        public string ZamanBargasht { get; set; }
        public bool Deleted { get; set; } = false;
        public int KilometerRaft { get; set; }
        public int KilometerBargasht { get; set; }

        public virtual string CarId { get; set; }


        public virtual string UserId { get; set; }

        public virtual string DriverId { get; set; }
        public virtual bool Finished { get; set; } = false;


    }
}
