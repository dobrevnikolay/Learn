using Ninject;
using System;
using System.Windows;
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
                //ToDo: Indicates the topic as complete
                MessageBox.Show("Correct Answer!");
           }
           else
           {
                MessageBox.Show("Incorrect Answer! You could try again!");
            }
            IoC.ControlKernel.Get<ControlViewModel>().CurrentControlContext = ControlContext.TopicMenu;
        }
        #endregion
    }
}
