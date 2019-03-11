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
            page.FillTransferMoneyAndMakePayment("Savings(Avail. balance = $ 1000)", "Checking(Avail. balance = $ -500.2)", "500.00", "Need money for Udemy Course");            
            page.btnContinue.Click();
            page.btnContinue.Click();

            Assert.IsTrue(page.msgExpected.Displayed);
            Assert.AreEqual(page.msgExpected.Text, "Transfer Money & Make Payments - Confirm");

            page.btnAnotherTransfer.Click();
            page.FillTransferMoneyAndMakePayment("Brokerage(Avail. balance = $ 197)", "Credit Card(Avail. balance = $ -265)", "350.00", "New description text");
            page.btnContinue.Click();
            page.btnContinue.Click();

            Assert.IsTrue(page.msgExpected.Displayed);
            Assert.AreEqual(page.msgExpected.Text, "Transfer Money & Make Payments - Confirm");
        }

        [Test]
        public void PayBill()
        {
            LoginPageObject pageLogin = new LoginPageObject();
            pageLogin.Login("username", "password");

            AccountSummaryPage page = new AccountSummaryPage();
            page.btnBillPay.Click();

            page.PopulatePaymentToSavedPayees("Bank of America", "Savings", "500.00", "2019-03-29", "Description for testing");          
            
            page.btnPay.Click();
            
            Assert.IsTrue(page.msgPayment.Displayed);
            Assert.AreEqual(page.msgPayment.Text, "The payment was successfully submitted.");

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
