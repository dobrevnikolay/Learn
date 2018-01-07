using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowBeginningEduGame.DataModels
{
    public class TopicModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Topic { get; set; }

        public string ImagePath { get; set; }
    }
}
