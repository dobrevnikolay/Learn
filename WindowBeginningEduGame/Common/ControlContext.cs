
namespace WindowBeginningEduGame
{
    /// <summary>
    /// States that could take control into Menu Page depending of the actions
    /// </summary>
    
    public enum ControlContext
    {
        /// <summary>
        /// Shows the menu with different topics
        /// </summary>

        TopicMenu = 0,

        /// <summary>
        /// Shows the text that you have to learn for the question
        /// </summary>

        Reading = 1,

        /// <summary>
        /// Shows the question that is related to the reading
        /// </summary>

        Question = 2,
    }
}
