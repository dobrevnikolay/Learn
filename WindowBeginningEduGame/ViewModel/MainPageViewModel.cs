namespace WindowBeginningEduGame
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// Stores the current Control Context
        /// </summary>

        private ControlContext mControlContext = ControlContext.TopicMenu;
        #endregion

        #region Properties

        /// <summary>
        /// Provide access to current Control context
        /// </summary>

        public ControlContext CurrentControlContext
        {
            get
            {
                return mControlContext;
            }
            set
            {
                mControlContext = value;
                this.OnPropertyChanged();
            }
        }
        #endregion
    }
}
