using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TimeMaterialAdd
{
    class TimeMaterialAdd
    {
        static void Main(string[] args)
        {


            //open chrome browser
            //IWebDriver driver = new ChromeDriver(@"C:\Users\moises.biason\Documents\ICTestAnalyst\ICTestAnalyst\TestAutoIntro1");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //launch turnup portal 
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username textbox and enter valid username
            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");

            //identify the password textbox and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //click login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            //check if uses is logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                //launch Time and Materail Page
                Console.WriteLine("Logged in successfully.");
                driver.Navigate().GoToUrl("http://horse.industryconnect.io/TimeMaterial");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");
            }


            //click Create New button
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createButton.Click();

            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]"));
            typeCode.SendKeys("Time");

            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("TestCode1");

            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("Test description 1");

            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement price = driver.FindElement(By.Id("Price"));
            
            priceTag.Click();
           
            price.SendKeys("12");

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
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

            if (codeEntry.Text == "TestCode1" && typecodeEntry.Text == "T")
            {
                Console.WriteLine("New record saved.");

            }
            else
            {
                Console.WriteLine("New record not saved.");
            }








        }
    }
}
