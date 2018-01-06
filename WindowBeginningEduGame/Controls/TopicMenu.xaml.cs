
using System.Windows.Controls;


namespace WindowBeginningEduGame
{
    /// <summary>
    /// Interaction logic for TopicMenu.xaml
    /// </summary>
    public partial class TopicMenu : UserControl
    {
        public TopicMenu()
        {
            InitializeComponent();
            DataContext = new TopicListViewModel();
        }
    }
}
