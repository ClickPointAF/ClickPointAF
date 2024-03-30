using ConfigurationProvider.Classes.Elements;
using ConfigurationProvider.Classes;
using ConfigurationProvider.Elements;
using ConfigurationProvider.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.PageObjects
{
    public partial class LoginPage
    {
        [Element("EmailTextBox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "Username")]
        public TextBox? EmailTextBox { get; }

        [Element("PasswordTextBox", ElementType.TextBox)]
        [Locator(LocatorType.Id, "Password")]
        public TextBox? PasswordTextBox { get; }

        [Element("LoginButton", ElementType.Button)]
        [Locator(LocatorType.Id, "loginBtn")]
        public Button? LoginButton { get; }
    }
}
