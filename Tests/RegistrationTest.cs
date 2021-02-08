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
            string email = "provjeratest@gmail.com";
            string password = "testnipassword12";
            string name = "provjeratest12";
            
            
            HomePage home_page = BasePage.OpenLoginForm();

            RegistrationPage register_page = home_page.SelectRegisterButton();

            register_page.RegisterUser(email, password,name);
            register_page.VerifyThatUserIsRegistered(name);

            
        }



    }
}
