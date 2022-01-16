using EmployeeAED.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeMaterialAED.Pages;
using TimeMaterialAED.Utilities;

namespace EmployeeAED.Tests
{
    [TestFixture]
    [Parallelizable]
    class EmployeeAED : Driver  
    {

        [Test, Order(1), Description("Check if user is able to add record in Employee Page.")]
        public void createEmployee()
        {

            Home home = new Home();
            home.GoToEmployeePage(driver);

            Employee employee = new Employee();
            employee.CreateEmployee(driver);
        }


    }
}
