using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SigService.Data.User
{
    class User : IUser
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Departament { get; set; }
    }
}
