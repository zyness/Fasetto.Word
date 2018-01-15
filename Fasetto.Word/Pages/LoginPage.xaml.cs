using System;
using System.Security;
using Fasetto.Word;
namespace Fasetto.Word
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage<LoginViewModel>, IHavePassword
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The secure password for thislogin page
        /// </summary>
        public SecureString SecurePassword
        {
            get
            {
                return PasswordText.SecurePassword;
            }
        }
    }
}
