using ConfigurationProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Models;

namespace TestSolution.PageObjects
{
    public partial class LoginPage
    {
        private void LoginWithCredentials(User user)
        {
            try
            {
                WriteInput("EmailTextBox", "Login Page", user.Email!);
                WriteInput("PasswordTextBox", "Login Page", user.Password!);
                ClickButton("LoginButton", "Login Page");
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to Log In with Given Credentials. {e.Message}.", e.InnerException);
            }
        }
    }
}
