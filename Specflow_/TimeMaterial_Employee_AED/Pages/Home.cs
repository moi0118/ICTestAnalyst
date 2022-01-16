using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeMaterialAED.Utilities;

namespace TimeMaterialAED.Pages
{
    class Home 
    {

        public void GoToTMPage(IWebDriver driver)

        {

           // driver.Navigate().GoToUrl("http://horse.industryconnect.io/TimeMaterial");

            IWebElement Administration = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            Administration.Click();

            IWebElement TimeAndMaterial = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
            TimeAndMaterial.Click();
        }

      

        public void GoToEmployeePage(IWebDriver driver)
        {
        
            IWebElement Administration = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            Administration.Click();

            IWebElement Employee = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[2] / a"));
            Employee.Click();
            
        }

    }
}
