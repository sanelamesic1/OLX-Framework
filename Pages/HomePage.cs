using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary2.Pages
{
    public class HomePage : BasePage
    {
        #region Elements

        IWebElement PRIJAVAbutton => driver.FindElement(By.XPath("//a[@id='loginbtn']"));
        IWebElement REGISTRUJTESEbutton => driver.FindElement(By.XPath("//a[@href='https://www.olx.ba/registracija']"));
        IWebElement USERNAMEtxtbox => driver.FindElement(By.XPath("//input[@id='username']"));
        IWebElement PASSWORDtxtbox => driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement LOGINbutton => driver.FindElement(By.XPath("//input[@id='btnlogin1']"));


        #endregion


        #region Constructors
        public HomePage(IWebDriver driver) : base(driver) { }

        #endregion

        #region Methods

        public HomePage OpenLoginForm()
        {
            PRIJAVAbutton.Click();
            
            return new HomePage(driver);
        }


        public RegistrationPage SelectRegisterButton ()
        {
            REGISTRUJTESEbutton.Click();

            return new RegistrationPage(driver);
        }



        public HomePage LoginOfUser(string password, string name)
        {
            USERNAMEtxtbox.Click();
            USERNAMEtxtbox.SendKeys(name);

            PASSWORDtxtbox.Click();
            PASSWORDtxtbox.SendKeys(password);

            LOGINbutton.Click();

            Assert.True(driver.FindElement(By.XPath("//a[@id='mojpikgore']")).Displayed);

            return new HomePage(driver);
        }



        #endregion



       



    }
}
