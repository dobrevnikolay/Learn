
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace WindowBeginningEduGame
{
    public class QuestionsViewModel
    {

        /// <summary>
        /// Storing the list of Topics
        /// </summary>
        protected TopicQuestion mTopic;
        
        #region Public Properties

        public TopicQuestion Topic
        {
            get
            {
                return mTopic;
            }
            set
            {
                if (value == mTopic)
                {
                    return;
                }
                else
                {
                    mTopic = value;
                }
            }
        }

        #endregion

        public QuestionsViewModel()
        {

            string topicName = "Astronomy";

            var topic = MongoDB.QuestionsCollection.Find<TopicQuestion>(x=> x.Topic == topicName).FirstOrDefault();

            if( null != topic )
            {
                mTopic = topic;
            }
            else
            {

            }
            
        }

    }
}
