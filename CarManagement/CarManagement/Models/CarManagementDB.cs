using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

using Shared;
using MongoDB.Driver;


namespace Models
{
    public abstract   class CarManagementDB
    {

        //protected  IMongoDatabase _db;

        //protected CarManagementDB()
        //{

        //    //_client = new MongoClient("mongodb://localhost:27017");
        //    //_server = _client.GetServer();
        //    //_db = _server.GetDatabase("EmployeeDB");
        //    var mongoClient = new MongoClient("mongodb://localhost:27017");

        //    _db = mongoClient.GetDatabase("CarManagement");

           
        //}

        public static  IMongoDatabase GetDb()
        {

            //_client = new MongoClient("mongodb://localhost:27017");
            //_server = _client.GetServer();
            //_db = _server.GetDatabase("EmployeeDB");
            var mongoClient = new MongoClient("mongodb://localhost:27017");

            return  mongoClient.GetDatabase("CarManagement");


        }



    }
}
