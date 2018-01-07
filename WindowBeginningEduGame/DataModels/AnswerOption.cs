using System;
using System.Windows.Input;

namespace WindowBeginningEduGame
{
    public class AnswerOption
    {
        #region Public properties

        public string Answer { get; set; }

        public bool IsCorrect { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Process the given answer
        /// </summary>
        public ICommand ProcessTheAnswerCommand { get; set; }

        #endregion

        #region Constructor

        public AnswerOption()
        {
            ProcessTheAnswerCommand = new RelayCommand(ProcessTheAnswer);
        }
        #endregion

        #region Helpers

        private void ProcessTheAnswer()
        {
           if(IsCorrect)
            {
                //Indicates the topic as complete
            }
           //Go to main menu
        }
        #endregion
    }
}
