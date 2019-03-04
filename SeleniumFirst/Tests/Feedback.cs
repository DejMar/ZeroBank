using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumFirst.Pages;
using System;
using System.Threading;

namespace SeleniumFirst.Tests
{
    public class Feedback
    {
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Navigate().GoToUrl("http://zero.webappsecurity.com/index.html");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void FeedbackFeature()
        {
            PageObject page = new PageObject();

            page.feedbackButton.Click();
            page.FillUserForm("Dejan", "mail@test.com", "Testiranje", "Komentar testa");

            Thread.Sleep(3000);

            page.btnSend.Click();

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }        
    }
}
