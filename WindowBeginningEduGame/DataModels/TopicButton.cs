
using System;
using System.Windows.Input;

namespace WindowBeginningEduGame
{
    public class TopicButton : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// Path to the background picture
        /// </summary>
        public string PathToPicture { get; set; }

        /// <summary>
        /// Topic Name, which will be retrieved from the DB
        /// </summary>
        public string TopicName { get; set; }

        /// <summary>
        /// If it is false that means that it has been already answered or there is no
        /// data for it in the DB
        /// </summary>
        public bool IsAvailable { get; set; } = true;

        public TopicQuestions Questions { get; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Opens the current topic
        /// </summary>
        public ICommand OpenTheTopic { get; set; }

        #endregion

        #region Constructor

        public TopicButton()
        {
            //read Questions from DB

            OpenTheTopic = new RelayCommand(OpenEduTopic);
        }

        private void OpenEduTopic()
        {
            
        }

        #endregion
    }
}
