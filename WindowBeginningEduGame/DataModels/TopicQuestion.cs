using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace WindowBeginningEduGame
{
    public class TopicQuestion
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Topic { get; set; }

        public string Introduction { get; set; }

        public string Question { get; set; }

        public List<AnswerOption> Answers { get; set; }
    }
}