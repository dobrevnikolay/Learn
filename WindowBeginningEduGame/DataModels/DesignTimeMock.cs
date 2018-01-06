namespace WindowBeginningEduGame
{
    public class DesignTimeMock : TopicButton
    {
        #region Singleton
        /// <summary>
        /// Single instance of the Design Mock
        /// </summary>

        public static DesignTimeMock Instance { get { return new DesignTimeMock(); } }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public DesignTimeMock()
        {
            PathToPicture = "/Images/astro.jpg";
            TopicName = "Astronomy";
            IsAvailable = true;
        }
        #endregion
    }
}
