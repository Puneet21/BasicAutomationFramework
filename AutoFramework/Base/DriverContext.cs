using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoFramework.Base
{
    public static class DriverContext
    {

        public static IWebDriver _driver= new ChromeDriver();

        

    }
}
