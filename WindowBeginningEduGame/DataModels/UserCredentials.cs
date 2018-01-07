using MongoDB.Bson;

namespace WindowBeginningEduGame
{
    public static class UserCredentials
    {
        public static ObjectId UserId { get; set; }

        public static string Username { get; set; }

        public static string CurrentTopic { get; set; } = null;
    }
}
