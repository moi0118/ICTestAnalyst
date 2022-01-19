using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TimeMaterialAED.Pages;
using TimeMaterialAED.Utilities;

namespace TM_Employee_AED
{
    [Binding]
    public class TM_Steps : Driver
    {
        public string descriptionBeforeDeleteEntry;
        TM tmObj = new TM();


        [Given(@"\[Successfully logged-in on the Turn-Up Portal]")]
        public void GivenSuccessfullyLogged_InOnTheTurn_UpPortal()
        {
            driver = new ChromeDriver();

            LogIn login = new LogIn();
            login.LoginSteps(driver);
        }

        [Given(@"\[Navigate to Time and Material Page]")]
        public void GivenNavigateToTimeAndMaterialPage()
        {
            Home home = new Home();
            home.GoToTMPage(driver);
        }

       
        [When(@"\[Creating a new Time and Material record]")]
        public void WhenCreatingANewTimeAndMaterialRecord()
        {
            tmObj.CreateTM(driver);
        }

        [Then(@"\[the new Time and Material record should be added successfully]")]
        public void ThenTheNewTimeAndMaterialRecordShouldBeAddedSuccessfully()
        {
            string codeEntry = tmObj.getCode(driver);
            string typecodeEntry = tmObj.getTypeCode(driver);
            string descriptionEntry = tmObj.getDescription(driver);
            string priceEntry = tmObj.getPrice(driver);

            Assert.That(codeEntry == "TestCode2", "Actual record and Code expected record do not matched.");
            Assert.That(typecodeEntry == "T", "Actual record and  Type Code expected record do not matched.");
            Assert.That(descriptionEntry == "Test description 2", "Actual record and Description expected record do not matched.");
            Assert.That(priceEntry == "$12.00", "Actual record and Price expected record do not matched.");
        }




        [Given(@"\[Successfully logged-in on the Turn-Up Portal\.]")]
        public void GivenSuccessfullyLogged_InOnTheTurn_UpPortal_()
        {
            driver = new ChromeDriver();

            LogIn login = new LogIn();
            login.LoginSteps(driver);
        }

        [Given(@"\[Navigate to Time and Material Page\.]")]
        public void GivenNavigateToTimeAndMaterialPage_()
        {
            Home home = new Home();
            home.GoToTMPage(driver);
        }

        
        [When(@"\[Editing the '([^']*)' and '([^']*)' of a Time and Material record\.]")]
        public void WhenEditingTheDescriptionOneAndCodeOneOfATimeAndMaterialRecord_(string description , string code)
        {
            tmObj.EditTM(driver, description, code);
        }

        [Then(@"\[the Time and Material record '([^']*)' and '([^']*)' should be updated successfully\.]")]
        public void ThenTheTimeAndMaterialRecordDescriptionOneAndCodeOneShouldBeUpdatedSuccessfully_(string description, string code)
        {
            string editedCode = tmObj.getEditedCode(driver);
            string editedDescription = tmObj.getEditedDescription(driver);

            Assert.That(editedCode == code, "Actual record and Code expected record do not matched.");
            Assert.That(editedDescription == description, "Actual record and Description expected record do not matched.");
        }





        [When(@"\[Deleting a Time and Material record]")]
        public void WhenDeletingATimeAndMaterialRecord()
        {
            descriptionBeforeDeleteEntry = tmObj.getBeforeDeleteDescription(driver);
            tmObj.DeleteTM(driver);
        }

        [Then(@"\[the Time and Material record should be deleted successfully]")]
        public void ThenTheTimeAndMaterialRecordShouldBeDeletedSuccessfully()
        {
            
            string descriptionAfterDeleteEntry = tmObj.getAfterDeleteDescription(driver);

            if (descriptionAfterDeleteEntry != descriptionBeforeDeleteEntry)

            {
                Assert.Pass("Record successfuly deleted");
            }
            else
            {
                Assert.Fail("Record not deleted");
            }
        }


        [Then(@"\[close the browser]")]
        public void ThenCloseTheBrowser()
        {
            driver.Quit();
        }






    }
}
