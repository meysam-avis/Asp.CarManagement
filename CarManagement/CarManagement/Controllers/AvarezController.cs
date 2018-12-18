
using Models;
using MongoDB.Bson;
using MongoDB.Driver;


namespace Controllers
{
    public class AvarezController 
    {


        public void Create(Avarez avarez)
        {
            CarManagementDB.GetDb().GetCollection<Avarez>("Avarez").InsertOne(avarez);
          
        }
        
        public void Update( Avarez p)
        {

            CarManagementDB.GetDb().GetCollection<Avarez>("Avarez").UpdateOneAsync(x => x.Id == p.Id,Builders<Avarez>.Update
                    .Set(u => u.Price, p.Price )
                    .Set(u => u.Rahgiri,p.Rahgiri ));
        }
    }
}
