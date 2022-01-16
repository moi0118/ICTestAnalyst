using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeMaterialAED.Utilities;

namespace EmployeeAED.Pages
{
    class Employee 
    {

        public void CreateEmployee(IWebDriver driver)
        {


            //click Create New button
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createButton.Click();


            IWebElement Name = driver.FindElement(By.Id("Name"));
            Name.SendKeys("Industry Connect");

            IWebElement Username = driver.FindElement(By.Id("Username"));
            Username.SendKeys("industryconnect01");

            IWebElement ContactDisplay = driver.FindElement(By.Id("ContactDisplay"));
            ContactDisplay.SendKeys("0402919105");

            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("Indusctryc1#");

            IWebElement RetypePassword = driver.FindElement(By.Id("RetypePassword"));
            RetypePassword.SendKeys("Indusctryc1#");


            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);
            Thread.Sleep(2000);


            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();
            Thread.Sleep(2000);
            //*[@id="container"]/div/a

            //Navigate to Last Page                                   
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(2000);


            //name
            IWebElement nameEntry = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //username
            IWebElement usernameEntry = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));


            // Assert Option 1
            Assert.That(nameEntry.Text == "Industry Connect", "Actual record and Name expected record do not match.");
            Assert.That(usernameEntry.Text == "industryconnect01", "Actual record and  Type Code expected record do not match.");



        }

        public void EditEmployee(IWebDriver driver)
        {
            //Navigate to Last Page
            driver.Manage().Window.Minimize();
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
                                                                      

            Thread.Sleep(4000);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editButton.Click();

            
            IWebElement editUsername = driver.FindElement(By.Id("Username"));
            editUsername.Clear();
            editUsername.SendKeys("industryconnect02");


            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            ////

            IWebElement backToList = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToList.Click();
            //*[@id="container"]/div/a

            driver.Manage().Window.Minimize();
            driver.Manage().Window.Maximize();
            //Navigate to Last Page
            //
            IWebElement lastPageButton2 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton2.Click();
            Thread.Sleep(4000);
            
            IWebElement editedUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            if (editedUsername.Text == "industryconnect02")

            {
                Assert.Pass("Username edited");
            }
            else
            {
                Assert.Fail("Edit not successful");
            }


        }


        public void DeleteEmployee(IWebDriver driver)
        {

            //Navigate to Last Page
            driver.Manage().Window.Minimize();
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();


            
            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            DeleteButton.Click();

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();


            Thread.Sleep(5000);
            IWebElement Username = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            if (Username.Text != "industryconnect02")

            {
                Console.WriteLine("Record successfuly deleted");
            }
            else
            {
                Console.WriteLine("Record not deleted");
            }





        }
    }
}
