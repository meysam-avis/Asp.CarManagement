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
    public class Fanni
    {
        [BsonId]
        public ObjectId Id { get; set; }


        public string Name { get; set; }
        public string Deleted { get; set; }
        public IList<FanniOperationDetail> FanniOperationDetail { set; get; }
    }
}
