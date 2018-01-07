using MongoDB.Driver;
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

            // If we try to retrieve a collection that does not exist yet in Mongo
            // the driver will automatically create the collection by itself, without throwing any exceptions.
            UserToAnsweredQuestionsMapping = Database.GetCollection<UserToAnsweredQuestionsMapping>("UserToAnsweredQuestionsMapping");
        }

        public static IMongoDatabase Database { get; set; }

        public static IMongoClient Client { get; set; }

        public static IMongoCollection<User> UsersCollection { get; set; }

        public static IMongoCollection<TopicModel> TopicsCollection { get; set; }

        public static IMongoCollection<TopicQuestion> QuestionsCollection { get; set; }

        public static IMongoCollection<UserToAnsweredQuestionsMapping> UserToAnsweredQuestionsMapping { get; set; }
    }
}
