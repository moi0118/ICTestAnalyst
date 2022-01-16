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


            //code
            IWebElement codeEntry = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));


            //typecode
            IWebElement typecodeEntry = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            //description xpath
            //*[@id="tmsGrid"]/div[3]/table/tbody/tr[7]/td[3]

            if (codeEntry.Text == "TestCode2" && typecodeEntry.Text == "T")
            {
                Console.WriteLine("New record saved.");

            }
            else
            {
                Console.WriteLine("New record not saved.");
            }


        }

        public void EditTM(IWebDriver driver)
        {
            
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();


          IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys("Edited Description.");


            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();


            Thread.Sleep(2000);
            //Navigate to Last Page
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();


            Thread.Sleep(2000);
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            if (Description.Text == "Edited Description.")

            {
                Console.WriteLine("Description edited");
            }
            else
            {
                Console.WriteLine("Edit not successful");
            }




        }


        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            DeleteButton.Click();

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();


            Thread.Sleep(5000);
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            if (Description.Text != "Edited Description.")

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
