using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TimeMaterialAED.Pages;
using TimeMaterialAED.Utilities;

namespace TimeMaterialAdd
{

    [TestFixture]
    class TimeMaterialAED : Driver
    {


        [OneTimeSetUp]
        public void Login()

        {

             driver = new ChromeDriver(@"C:\Users\moises.biason\Documents\ICTestAnalyst\ICTestAnalyst\TestAutoIntro1");


            //LogIn Page object initialization
            LogIn logIn = new LogIn();

            logIn.LoginSteps(driver);

            //Home Page object initialization
            Home home = new Home();

            home.GoToTMPage(driver);

        }

        [Test, Order(1), Description("Check if user is able to add record in Time and Material Page.")]
        public void CreateTM()
        {

            //TM Page object initialization
            TM tm = new TM();
            tm.CreateTM(driver);

        }

        [Test, Order(2), Description("Check if user is able to edit record in Time and Material Page.")]
        public void EditTM()
        {
            TM tm = new TM();
            tm.EditTM(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete record in Time and Material Page.")]
        public void DeleteTM()
        {
            TM tm = new TM();
            tm.DeleteTM(driver);
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }


    }
}

