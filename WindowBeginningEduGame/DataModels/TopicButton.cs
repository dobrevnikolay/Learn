using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WindowBeginningEduGame
{
    public class TopicButton : Button
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

        #endregion

        #region Constructor

        public TopicButton(string path, string topicName )
        {
            PathToPicture = path;
            TopicName = topicName;
        }

        #endregion
    }
}
