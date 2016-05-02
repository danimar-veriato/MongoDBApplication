using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBApplication
{
    public class DBMongo
    {
        public static void  getCollecao(string nomeCol)
        {
            //String de conexão ao MongoDB
            string connectionString = "mongodb://localhost:27017";
            var MongoClient = new MongoClient(connectionString);
            var db = MongoClient.GetDatabase("FOCKINK");
            var collec = db.GetCollection<Orcamento>(nomeCol);
        }
    }
}