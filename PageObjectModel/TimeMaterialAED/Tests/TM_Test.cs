using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TimeMaterialAED.Pages;

namespace TimeMaterialAdd
{
    class TimeMaterialAED
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver(@"C:\Users\moises.biason\Documents\ICTestAnalyst\ICTestAnalyst\TestAutoIntro1");


            //LogIn Page object initialization
            LogIn logIn = new LogIn();
           
            logIn.LoginSteps(driver);

            //Home Page object initialization
            Home home = new Home();
           
            home.GoToTMPage(driver);

            //TM Page object initialization
            TM tm = new TM();
       //     tm.CreateTM(driver);

       //     tm.EditTM(driver);

      //      tm.DeleteTM(driver);
        }
    }
}
