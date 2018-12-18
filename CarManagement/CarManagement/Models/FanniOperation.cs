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
  public   class FanniOperation
    {
        [BsonId]
        public ObjectId Id { get; set; }


        //public int CarId { get; set; }
        //public int FanniId { get; set; }
        public long Price { get; set; }
        public string Tarikh { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public Car Car { set; get; }
        //public Fanni Fanni { set; get; }
        public IList<FanniOperationDetail> FanniOperationDetail { set; get; }

    }
}
