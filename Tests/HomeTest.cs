using ClassLibrary2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Tests
{
    public class HomeTest : BaseTest
    {

        //TESTING
        [Test]
        public void VerifyThatUserCanLoginTests()
        {
            string name = "ime123test12";
            string password = "testtest1234";
            
            HomePage home_page = BasePage.OpenLoginForm();

            home_page.LoginOfUser(password, name);
        }

       
       
        



    }
}
