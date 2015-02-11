using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPoly.Models
{
    [BsonIgnoreExtraElements]
    public class Cat : Animal
    {
        public bool HasClaw { get; set; }
    }
}
