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
    public class FanniOperationDetail
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public Fanni Fanni { set; get; }
        public FanniOperation FanniOperation { set; get; }
    }
}
