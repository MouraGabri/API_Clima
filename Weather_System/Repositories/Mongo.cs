using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_System.Models;

namespace Weather_System.Repositories
{
    public class Mongo
    {
        string connectionString = "mongodb://localhost:27017";
        private IMongoCollection<Root_Model> _usuariosCollection;

        public Mongo()
        {
            OpenConnection();
        }

        private void OpenConnection()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("api_tempo1");
            _usuariosCollection = database.GetCollection<Root_Model>("consultas_clima");
        }

        public void Insert(Root_Model json)
        {
            try
            {
                _usuariosCollection.InsertOne(json);

            }
            catch (Exception)
            {

                throw;
            }

        }














    }



}
