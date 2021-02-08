using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary2.Pages
{


    public class RegistrationPage : BasePage
    {
        #region Elements

        IWebElement LOGINbutton => driver.FindElement(By.XPath("//a[@id='loginbtn']"));
        IWebElement CLEANCOOKIESbutton => driver.FindElement(By.XPath("//*[@id='cookiesBar']/p/button"));
        IWebElement REGISTRUJTESEbutton => driver.FindElement(By.XPath("//a[@href='https://www.olx.ba/registracija']"));
        IWebElement REGISTRUJPROFILbutton => driver.FindElement(By.XPath("//a[@onclick='korak2()']"));
        IWebElement EMAILtxtbox => driver.FindElement(By.XPath("//input[@id='email']"));
        IWebElement PASSWORDtxtbox => driver.FindElement(By.XPath("//input[@id='reg-password']"));
        IWebElement OLXIMEtxtbox => driver.FindElement(By.XPath("//input[@id='reg-username']"));
        IWebElement SPOLbutton => driver.FindElement(By.XPath("//div[@id='spol1']"));
        IWebElement LOKACIJAdropdown => driver.FindElement(By.XPath("//select[@id='kanton']/option[@value='1']"));
        IWebElement MJESTOdropdown => driver.FindElement(By.XPath("//select/option[contains(text(), 'Bihać')]"));
        IWebElement USLOVIKORIŠTENJAcheckbox => driver.FindElement(By.XPath("//input[@id='tos']"));
        IWebElement ZAVRSIREGISTRACIJUbutton => driver.FindElement(By.XPath("//button[@type='submit']"));


        #endregion



        #region Constructors
        public RegistrationPage(IWebDriver driver) : base(driver) { }
        #endregion



        #region Methods

        //new user registration
        public RegistrationPage RegisterUser(string email, string password, string name)
        {
            //LOGINbutton.Click();
            //REGISTRUJTESEbutton.Click();
            REGISTRUJPROFILbutton.Click();
            CLEANCOOKIESbutton.Click();
            EMAILtxtbox.SendKeys(email);
            PASSWORDtxtbox.SendKeys(password);
            OLXIMEtxtbox.SendKeys(name);
            SPOLbutton.Click();
            LOKACIJAdropdown.Click();
            Thread.Sleep(300);
            USLOVIKORIŠTENJAcheckbox.Click();
            MJESTOdropdown.Click();
            ZAVRSIREGISTRACIJUbutton.Click();

            return new RegistrationPage(driver);
        }

        //verfy that user is registred
        public RegistrationPage VerifyThatUserIsRegistered(string name)
        {

            Assert.True(driver.FindElement(By.XPath($"//strong[text()='{name}']")).Displayed, "Yes");

            return new RegistrationPage(driver);
        }


        #endregion


    }




}
