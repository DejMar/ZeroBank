using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumFirst.Pages;
using System;
using System.Threading;


namespace SeleniumFirst.Tests
{
    class AccountSummaryTest
    {
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Navigate().GoToUrl("http://zero.webappsecurity.com/index.html");
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void AccountSummary()
        {
            LoginPageObject pageLogin = new LoginPageObject();
            pageLogin.Login("username", "password");
            AccountSummaryPage page = new AccountSummaryPage();
            page.btnSavings.Click();
            page.CheckingOption();            
        }      

        [Test]
        public void TransferFunds()
        {
            LoginPageObject pageLogin = new LoginPageObject();
            pageLogin.Login("username", "password");
            AccountSummaryPage page = new AccountSummaryPage();
            page.btnTransferFunds.Click();
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
