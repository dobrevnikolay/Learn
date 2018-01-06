

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WindowBeginningEduGame
{
    class TopicListViewModel : BaseViewModel
    {
        /// <summary>
        /// Storing the list of Topics
        /// </summary>
        protected List<TopicButton> mItems;


        public List<TopicButton> Items
        {
            get
            {
                return mItems;
            }
            set
            {
                if(value == mItems)
                {
                    return;
                }
                else
                {
                    mItems = value;
                }
            }
        }

        #region Constructor
        public TopicListViewModel() => mItems = new List<TopicButton>
            {
                new TopicButton
                {
                    TopicName = "Astronomy",
                    PathToPicture = "/Images/astro.jpg",
                    IsAvailable = true
                },
                new TopicButton
                {
                    TopicName = "Geography",
                    PathToPicture = "/Images/geog.jpg",
                    IsAvailable = true
                },
                new TopicButton
                {
                    TopicName = "Movies",
                    PathToPicture = "/Images/movie.jpg",
                    IsAvailable = true
                },
            };
        #endregion

    }
}
