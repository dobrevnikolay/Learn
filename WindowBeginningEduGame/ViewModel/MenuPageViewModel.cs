using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace WindowBeginningEduGame
{
    class MenuPageViewModel : BaseViewModel
    {
        #region Members
                
        /// <summary>
        /// Storing the list of Topics
        /// </summary>
        protected List<TopicButton> mItems;

        #endregion

        #region Public Properties

        public List<TopicButton> Items
        {
            get
            {
                return mItems;
            }
            set
            {
                if (value == mItems)
                {
                    return;
                }
                else
                {
                    mItems = value;
                }
            }
        }

        #endregion


        #region Constructor
        public MenuPageViewModel()
        {
            var topics = MongoDB.TopicsCollection.AsQueryable()
                .Select(x => new TopicButton
                {
                    Topic = x.Topic,
                    ImagePath = x.ImagePath,
                    IsAvailable = true
                }).ToList();

            mItems = topics;

            // Example how to insert answered questions
            var userToAnsweredQuestionsMapping = MongoDB.UserToAnsweredQuestionsMapping.Find(x => x.UserId == UserCredentials.UserId).FirstOrDefault();
            if (userToAnsweredQuestionsMapping != null)
            {
                // The topic question will be taken from the question that the user is answering at the moment.
                var topicQuestion = new TopicQuestion();

                var updateDefinition = Builders<UserToAnsweredQuestionsMapping>.Update
                    .AddToSet<TopicQuestion>(x => x.QuestionsAnsweredCorrectly, topicQuestion);

                // Find the document and update the array.
                MongoDB.UserToAnsweredQuestionsMapping.FindOneAndUpdate(
                    x => x.UserId == UserCredentials.UserId,
                    updateDefinition);
            }
            else
            {
                userToAnsweredQuestionsMapping = new UserToAnsweredQuestionsMapping
                {
                    UserId = UserCredentials.UserId,
                    Username = UserCredentials.Username,
                    QuestionsAnsweredCorrectly = new List<TopicQuestion>
                    {
                        // The question that is being answered currently by the user
                        new TopicQuestion()
                    }
                };

                MongoDB.UserToAnsweredQuestionsMapping.InsertOne(userToAnsweredQuestionsMapping);
            }
        }

        #endregion

    }
}
