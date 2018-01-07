using System.Windows.Controls;

namespace WindowBeginningEduGame
{
    /// <summary>
    /// Interaction logic for ReadingControl.xaml
    /// </summary>
    public partial class ReadingControl : UserControl
    {
        public ReadingControl()
        {
            InitializeComponent();
            this.DataContext = new QuestionsViewModel();
        }
    }
}
