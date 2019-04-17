using System;
using AutoFramework.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {


       

      

        [TestMethod]
        public void TestMethod1()
        {
            Pages.LoginPage.Login("puneet","arora");
            string name = "puneet";
            
        }

       

    }
}
