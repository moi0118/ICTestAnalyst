using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestAutoIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
       

            //open chrome browser
            IWebDriver driver = new ChromeDriver(@"C:\Users\moises.biason\Documents\ICTestAnalyst\ICTestAnalyst\TestAutoIntro1");
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
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");
            }

   

        }
    }
}
