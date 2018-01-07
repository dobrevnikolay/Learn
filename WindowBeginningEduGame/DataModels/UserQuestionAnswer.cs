﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace WindowBeginningEduGame
{
    public class UserQuestionAnswer
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public ObjectId UserId { get; set; }

        public string Username { get; set; }

        public List<TopicQuestion> QuestionsAnswered { get; set; }
    }
}
