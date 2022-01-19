using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TimeMaterialAED.Utilities;

namespace TimeMaterialAED.Pages
{
    class TM
    {

        public void CreateTM(IWebDriver driver)
        {

            //click Create New button
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createButton.Click();

            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]"));
            typeCode.SendKeys("Time");

            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("TestCode2");

            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("Test description 2");

            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement price = driver.FindElement(By.Id("Price"));

            priceTag.Click();

            price.SendKeys("12");

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);
            Thread.Sleep(2000);

            //Navigate to Last Page
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(2000);

        }

        //return code
        public string getCode(IWebDriver driver)
        {
            IWebElement codeEntry = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return codeEntry.Text;

        }

        //return typecode
        public string getTypeCode(IWebDriver driver)
        {
            
            IWebElement typecodeEntry = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return typecodeEntry.Text;
        }

        //return description
        public string getDescription(IWebDriver driver)
        {
            IWebElement descriptionEntry = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return descriptionEntry.Text;
        }

       
        //return price
        public string getPrice(IWebDriver driver)
        { 
            IWebElement priceEntry = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return priceEntry.Text;
        }



        public void EditTM(IWebDriver driver, string description, string code)
        {
            Thread.Sleep(1000);
            driver.Manage().Window.Minimize();
            driver.Manage().Window.Maximize();

            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
         
            Thread.Sleep(2000);

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();


            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Click();
            editCode.Clear();
            editCode.SendKeys(code);

            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys(description);


            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();


            Thread.Sleep(4000);
            //Navigate to Last Page
            IWebElement lastPageButton2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton2.Click();
            Thread.Sleep(2000);
            

        }


        public string getEditedCode(IWebDriver driver)
        {
            IWebElement Code = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return Code.Text;

        }

        public string getEditedDescription(IWebDriver driver)
        {
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return Description.Text;

        }



        public string getBeforeDeleteDescription(IWebDriver driver)
        {
            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();

            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();


            IWebElement Description = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return Description.Text;
        }

        public void DeleteTM(IWebDriver driver)
        {


            Thread.Sleep(1000);
            driver.Manage().Window.Maximize();
                                                                      
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();


            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            DeleteButton.Click();

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();


            Thread.Sleep(4000);
           

        }

        public string getAfterDeleteDescription(IWebDriver driver)
        {
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return Description.Text;
        }


    }





}
