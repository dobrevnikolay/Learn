using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowBeginningEduGame.DataModels;

namespace WindowBeginningEduGame
{
    public static class MongoDB
    {
        static MongoDB()
        {
            Client = new MongoClient("mongodb://localhost:27017");
            Database = Client.GetDatabase("LearnDB");
            UsersCollection = Database.GetCollection<User>("Users");
            TopicsCollection = Database.GetCollection<TopicModel>("Topics");
            QuestionsCollection = Database.GetCollection<TopicQuestion>("Questions");
        }

        public static IMongoDatabase Database { get; set; }

        public static IMongoClient Client { get; set; }

        public static IMongoCollection<User> UsersCollection { get; set; }

        public static IMongoCollection<TopicModel> TopicsCollection { get; set; }

        public static IMongoCollection<TopicQuestion> QuestionsCollection { get; set; }
    }
}
