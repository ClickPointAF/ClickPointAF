using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Models;

namespace TestSolution.PageObjects
{
    public partial class NavbarPage
    {
        private void GoToCreateLeadSource()
        {
            try
            {
                ClickButton("CreateLeadSourceButton", "Welcome Page");
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to Go to Create a Lead Source. {e.Message}.", e.InnerException);
            }
        }
    }
}
