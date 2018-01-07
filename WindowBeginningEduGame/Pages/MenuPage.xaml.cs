using System.Security;
using System.Windows.Controls;


namespace WindowBeginningEduGame
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();

            this.DataContext = new MainPageViewModel();
        }
    }
}
