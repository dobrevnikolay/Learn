using System.Windows.Controls;

namespace WindowBeginningEduGame
{
    /// <summary>
    /// Interaction logic for TopicMenuControl.xaml
    /// </summary>
    public partial class TopicMenuControl : UserControl
    {
        public TopicMenuControl()
        {
            InitializeComponent();

            this.DataContext = new MenuPageViewModel();
        }
    }
}
