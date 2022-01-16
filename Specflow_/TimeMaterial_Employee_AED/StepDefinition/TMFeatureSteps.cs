using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TimeMaterialAED.Pages;
using TimeMaterialAED.Utilities;

namespace TM_Employee_AED.StepDefinition
{
    [Binding]
    public class TimeAndMaterialFeatureSteps : Driver
    {

        TM tmObj = new TM();


        [Given(@"Successfully logged-in on the Turn-Up Portal")]
        public void GivenSuccessfullyLogged_InOnTheTurn_UpPortal()
        {
            driver = new ChromeDriver();

            LogIn login = new LogIn();
            login.LoginSteps(driver);
        }
        
        [Given(@"Navigate to Time and Material Page")]
        public void GivenNavigateToTimeAndMaterialPage()
        {
            Home home = new Home();
            home.GoToTMPage(driver);
        }
        
        [When(@"Creating a new Time and Material record")]
        public void WhenCreatingANewTimeAndMaterialRecord()
        {
            tmObj.CreateTM(driver);
        }


        [Then(@"the new Time and Material record should be added successfully")]
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



        [When(@"Editing the (.*) of a Time and Material record")]
        public void WhenEditingTheDescriptionOneOfATimeAndMaterialRecord(string p0)
        {
            tmObj.EditTM(driver, p0);
        }
        
        
        
        [Then(@"the Time and Material record (.*) should be updated successfully")]
        public void ThenTheTimeAndMaterialRecordDescriptionOneShouldBeUpdatedSuccessfully(string p0)
        {
            string descriptionEntry = tmObj.getEditedEntry(driver);


            if (descriptionEntry == p0)

            {
                Assert.Pass("Description edited");
            }
            else
            {
                Assert.Fail("Edit not successful");
            }
        }



        [When(@"Deleting the an Employee record")]
        public void WhenDeletingTheAnEmployeeRecord(string p0)
        {

            tmObj.DeleteTM(driver);
           
        }

        [Then(@"the Employee record should be deleted successfully")]
        public void ThenTheEmployeeRecordShouldBeDeletedSuccessfully()
        {

            string descriptionDeleteEntry = tmObj.getDeleteDescription(driver);

            if (descriptionDeleteEntry != "descriptionTwo")

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
