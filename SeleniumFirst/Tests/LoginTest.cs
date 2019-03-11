using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumFirst.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst.Tests
{
    class LoginTest
    {
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Navigate().GoToUrl("http://zero.webappsecurity.com/index.html");
            PropertiesCollection.driver.Manage().Window.Maximize();
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void Login()
        {
            LoginPageObject pageLogin = new LoginPageObject();
            pageLogin.Login("username", "password");
        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }

    }
}
