using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeMaterialAED.Pages;

namespace TimeMaterialAED.Utilities
{
    class Driver
    {
        public IWebDriver driver; 


        [OneTimeSetUp]
        public void Login()

        {
            driver = new ChromeDriver();



            //LogIn Page object initialization
            LogIn logIn = new LogIn();

            logIn.LoginSteps(driver);

        }


        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
