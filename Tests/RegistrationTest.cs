using ClassLibrary2.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Tests
{
    class RegistrationTest : BaseTest
    {

        [Test]
        public void VerifyThatNewUserCanRegister()
        {
            string email = "testniuser12345@gmail.com";
            string password = "testnipassword";
            string name = "testnoime12345";
            
            
            HomePage home_page = BasePage.OpenLoginForm();

            RegistrationPage register_page = home_page.SelectRegisterButton();

            register_page.RegisterUser(email, password,name);
            register_page.VerifyThatUserIsRegistered(name);

            
        }



    }
}
