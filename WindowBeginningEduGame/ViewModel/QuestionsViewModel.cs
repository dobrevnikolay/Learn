
using MongoDB.Driver;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace WindowBeginningEduGame
{
    public class QuestionsViewModel : BaseViewModel
    {

        /// <summary>
        /// Storing the list of Topics
        /// </summary>
        protected TopicQuestion mTopic;

        public ICommand BackToMenuCommand { get; set; }

        public ICommand ProcessToQuestionsCommand { get; set; }
        
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
            BackToMenuCommand = new RelayCommand(BackToMenu);
            ProcessToQuestionsCommand = new RelayCommand(ProcessToQuestions);

            string topicName = UserCredentials.CurrentTopic;

            var topic = MongoDB.QuestionsCollection.Find<TopicQuestion>(x=> x.Topic == topicName).FirstOrDefault();

            if( null != topic )
            {
                mTopic = topic;
            }
            else
            {

            }
            
        }

        private void ProcessToQuestions()
        {
            IoC.ControlKernel.Get<ControlViewModel>().CurrentControlContext = ControlContext.Question;
        }

        private void BackToMenu()
        {
            IoC.ControlKernel.Get<ControlViewModel>().CurrentControlContext = ControlContext.TopicMenu;
        }
    }
}
