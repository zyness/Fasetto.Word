using System;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word
{
    /// <summary>
    /// The View Model for the loginscreen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties
        /// <summary>
        /// Email of the user
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The users password
        /// </summary>
        public SecureString Password { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            //Create commands
            LoginCommand = new RelayParameterizedCommand(async(parameter) => await Login(parameter));            
        }
        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view fro the users password</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            await Task.Delay(500);
           var pass = (parameter as SecureString).Unsecure();
        }
        #endregion

    }
}


 