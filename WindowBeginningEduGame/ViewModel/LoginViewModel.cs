using MongoDB.Driver;
using System;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WindowBeginningEduGame
{
    public class LoginViewModel : BaseViewModel
    {
        #region Private Member

        /// <summary>
        /// Indicates if there is Login in process
        /// </summary>

        private bool LoginIsRunning = false;

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>

        public ICommand RegistrationCommand { get; set; }

        public ICommand LoginCommand { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>

        public string Email { get; set; }

        /// <summary>
        /// The users password
        /// </summary>

        public SecureString Password { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>

        public LoginViewModel()
        {
            RegistrationCommand = new RelayParameterizedCommand(async (parameter) => await Register(parameter));
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
        }

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password </param>
        /// <returns></returns>

        private async Task Login(object parameter)
        {
            try
            {
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
                var username = this.Email;
                var dbUser = MongoDB.UsersCollection.Find(x => x.Username == username && x.Password == pass).FirstOrDefault();
                if (dbUser != null)
                {
                    UserCredentials.UserId = dbUser.Id;
                    UserCredentials.Username = dbUser.Username;

                    ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.MenuPage;
                }
                else
                {
                    MessageBox.Show("Invalid user credentials. Please try login again.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Connection to database could not be established.");
            }
            finally
            {
                RegistrationCommand = new RelayParameterizedCommand(async (param) => await Login(param));
            }

            // Connect To DB, check whether there is such email already registered
            //  if there is such email, check the password
            //      if the password is valid proceed

            //      if the password is invalid return the same MessageBox
            //      the message box should have the following logic:
            //      There is no such email registered or the password is invalid.
            //      Please make sure there are no spelling mistakes and try again or 
            //      register yourself
            // if there is no such email return MessageBox with appropriate message

            
        }

        #endregion

        /// <summary>
        /// Attempts to register the user
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password </param>
        /// <returns></returns>

        public async Task Register(object parameter)
        {
            //Check with regex if the input is valid email adress
            //  Check if the following mail is not registered yet
            //      if it is: The following email has been already registered
            //          please try to enter with it by selecting the option below: 
            //          I already have an account
            //  if not so:
            //      enter the mail and the password to the database end proceed
            // CHeck if user credential fields are not empty before registering the user
            try
            {
                if (LoginIsRunning)
                {
                    return;
                }
                else
                {
                    //for Test purposes, do not store the unsecure password into variable
                    var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
                    var username = this.Email;

                    var newUser = new User
                    {
                        Password = pass,
                        Username = username
                    };

                    try
                    {
                        // Insert user in db
                        MongoDB.UsersCollection.InsertOne(newUser);

                        // Check if user is successfully inserted
                        var dbUser = MongoDB.UsersCollection.Find<User>(x => x.Username == username && x.Password == pass).FirstOrDefault();

                        if (dbUser != null)
                        {
                            MessageBox.Show("User successfully registered.");
                            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.MenuPage;
                        }
                        else
                        {
                            MessageBox.Show("User registration failed.");
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("User registration failed.");
                    }
                }
            }
            catch
            {
            }
            finally
            {
                LoginIsRunning = false;
            }
        }
    }
}
