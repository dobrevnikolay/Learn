

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WindowBeginningEduGame
{
    class TopicListViewModel : BaseViewModel
    {
        /// <summary>
        /// Storing the list of Topics
        /// </summary>
        protected List<TopicButtonViewModel> mItems;


        public List<TopicButtonViewModel> Items
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
        public TopicListViewModel() => mItems = new List<TopicButtonViewModel>
            {
                new TopicButtonViewModel
                {
                    Topic = "Astronomy",
                    ImagePath = "/Images/astro.jpg",
                    IsAvailable = true
                },
                new TopicButtonViewModel
                {
                    Topic = "Geography",
                    ImagePath = "/Images/geog.jpg",
                    IsAvailable = true
                },
                new TopicButtonViewModel
                {
                    Topic = "Movies",
                    ImagePath = "/Images/movie.jpg",
                    IsAvailable = true
                },
            };
        #endregion

    }
}
