using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoly.Models
{
    [BsonIgnoreExtraElements]
    public abstract class Animal
    {
        [BsonId]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
