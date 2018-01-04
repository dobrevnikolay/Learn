using System.Security;
using System.Windows.Controls;


namespace WindowBeginningEduGame
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class LoginPage : Page, IHavePassword
    {
        public LoginPage()
        {
            InitializeComponent();

            this.DataContext = new LoginViewModel();
        }

        /// <summary>
        /// The Secure password for this login page
        /// </summary>
        public SecureString SecurePassword => PasswordText.SecurePassword;
    }
}
