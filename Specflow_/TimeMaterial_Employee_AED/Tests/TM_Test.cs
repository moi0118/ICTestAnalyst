using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TimeMaterialAED.Pages;
using TimeMaterialAED.Utilities;

namespace TimeMaterialAED
{

    [TestFixture]
    [Parallelizable]
    class TimeMaterialAED : Driver
    {
       

        [Test, Order(1), Description("Check if user is able to add record in Time and Material Page.")]
        public void CreateTM()
        {

            //Home Page object initialization
            Home home = new Home();
            home.GoToTMPage(driver);


            //TM Page object initialization
            TM tm = new TM();
            tm.CreateTM(driver);

        }

        [Test, Order(2), Description("Check if user is able to edit record in Time and Material Page.")]
        public void EditTM()
        {
            //Home Page object initialization
            Home home = new Home();
            home.GoToTMPage(driver);

            TM tm = new TM();
            tm.EditTM(driver, "description");
        }

        [Test, Order(3), Description("Check if user is able to delete record in Time and Material Page.")]
        public void DeleteTM()
        {

            //Home Page object initialization
            Home home = new Home();
            home.GoToTMPage(driver);


            TM tm = new TM();
            tm.DeleteTM(driver);
        }

       


    }
}

