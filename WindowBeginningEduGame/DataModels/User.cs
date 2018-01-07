﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowBeginningEduGame
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
