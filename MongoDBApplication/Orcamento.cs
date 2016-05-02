using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBApplication
{
    public class Orcamento
    {
        public ObjectId idDocumento { get; set; }
        public string  codigo { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }



    }
}
