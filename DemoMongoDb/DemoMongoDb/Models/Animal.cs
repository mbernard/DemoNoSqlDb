using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMongoDb.Models
{
    public abstract class Animal
    {
        private int _id;

        [BsonId]
        public int Id
        {
            get
            {
                if(this._id == 0)
                {
                    this._id = new Random().Next();
                }

                return this._id;
            }
        }

        public string Name { get; set; }
    }
}
