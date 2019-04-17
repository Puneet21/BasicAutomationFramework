using System;
using AutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace AutoFramework.Pages
{
    public class LoginPage
    {
        

        private IWebElement txtUserName => DriverContext._driver.FindElement(By.Name("userName"));
        private IWebElement txtPassword => DriverContext._driver.FindElement(By.Name("password"));
        private IWebElement btnSignIn => DriverContext._driver.FindElement(By.Name("login"));

        public void Login(string userName, string password)
        {
            DriverContext._driver.Navigate().GoToUrl(Config.TestSettings.Default["URL"].ToString());

            //WebDriverWait _wait = new WebDriverWait(DriverContext._driver, TimeSpan.FromSeconds(4000));
            //_wait.Until(d => txtUserName);



            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnSignIn.Click();
         
          }

    }
}

