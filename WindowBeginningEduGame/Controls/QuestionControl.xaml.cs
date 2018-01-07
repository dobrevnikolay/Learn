using System.Windows.Controls;

namespace WindowBeginningEduGame
{
    /// <summary>
    /// Interaction logic for QuestionControl.xaml
    /// </summary>
    public partial class QuestionControl : UserControl
    {
        public QuestionControl()
        {
            InitializeComponent();

            this.DataContext = new QuestionsViewModel();
        }
    }
}
