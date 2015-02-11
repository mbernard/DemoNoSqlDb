using DemoPoly.Models;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using MongoDB.Bson.Serialization;

namespace DemoPoly.Repositories
{
    public class AnimalRepository
    {
        private MongoClient _client;
        private MongoCollection<Animal> _collection;
        private MongoDatabase _database;

        public AnimalRepository()
        {
            this._client = new MongoClient("mongodb://localhost:27017");
            this._database = this._client.GetServer().GetDatabase("DemoPoly");
            this._collection = this._database.GetCollection<Animal>("Animals");

            BsonClassMap.RegisterClassMap<Cat>();
            BsonClassMap.RegisterClassMap<Bird>();
        }

        public IQueryable<Animal> Get()
        {
            return this._collection.AsQueryable();
        }

        public void Add(Animal animal)
        {
            this._collection.Insert(animal);
        }

        public void Delete(int animalId)
        {
            this._collection.Remove(Query<Animal>.Where(x => x.Id == animalId));
        }
    }
}
