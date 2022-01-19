using System;
using EmployeeAED.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TimeMaterialAED.Pages;
using TimeMaterialAED.Utilities;

namespace TM_Employee_AED
{
    [Binding]
    public class Employee_Steps : Driver
    {
        public string usernameBeforeDelete;
        Employee employeeObj = new Employee();
        Home home = new Home();

        [Given(@"\[User is successfully logged-in on the Turn-Up Portal]")]
        public void GivenUserIsSuccessfullyLogged_InOnTheTurn_UpPortal()
        {
            driver = new ChromeDriver();

            LogIn login = new LogIn();
            login.LoginSteps(driver);
        }

        [Given(@"\[Navigate to Employee Page]")]
        public void GivenNavigateToEmployeePage()
        {
           
            home.GoToEmployeePage(driver);
        }


        [When(@"\[Creating a new Employee record]")]
        public void WhenCreatingANewEmployeeRecord()
        {
            employeeObj.CreateEmployee(driver);
        }

        [Then(@"\[the new Employee record should be added successfully]")]
        public void ThenTheNewEmployeeRecordShouldBeAddedSuccessfully()
        {

            string nameEntry = employeeObj.getNameEntry(driver);
            string usernameEntry = employeeObj.getUserNameEntry(driver);

   
            Assert.That(nameEntry == "Industry Connect03", "Actual record and Name expected record do not match.");
            Assert.That(usernameEntry == "industryconnect03", "Actual record and  Type Code expected record do not match.");
        }

        [Then(@"\[close browser]")]
        public void ThenCloseBrowser()
        {
            
                driver.Quit();
        }

       
        
        [When(@"\[Editing the '([^']*)' and '([^']*)' of an Employee record\.]")]
        public void WhenEditingTheAndOfAnEmployeeRecord_(string name, string username)
        {


            home.GoToEmployeePage(driver);
            employeeObj.EditEmployee(driver, name, username);


        }

        [Then(@"\[the Employee record '([^']*)' and '([^']*)' should be updated successfully\.]")]
        public void ThenTheEmployeeRecordAndShouldBeUpdatedSuccessfully_(string name , string username)
        {
            string editedName = employeeObj.getEditedName(driver);
            string editedUsername = employeeObj.getEditedUserName(driver);


            Assert.That(editedName == name, "Actual record and Name expected record do not match.");
            Assert.That(editedUsername == username, "Actual record and  Type Code expected record do not match.");

        }

        
        
        [When(@"\[Deleting the an Employee record]")]
        public void WhenDeletingTheAnEmployeeRecord()
        {
            usernameBeforeDelete = employeeObj.getBeforeDeleteUsername(driver);
            employeeObj.DeleteEmployee(driver);
        }

        [Then(@"\[the Employee record should be deleted successfully]")]
        public void ThenTheEmployeeRecordShouldBeDeletedSuccessfully()
        {
            string usernameAfterDelete = employeeObj.getAfterDeleteUsername(driver);
            
            if (usernameBeforeDelete != usernameAfterDelete)

            {
                Assert.Pass("Record successfuly deleted");
            }
            else
            {
                Assert.Fail("Record not deleted");
            }
        }
    }
}
