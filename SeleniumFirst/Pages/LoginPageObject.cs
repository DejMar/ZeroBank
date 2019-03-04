using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst.Pages
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "signin_button")]
        public IWebElement btnSignin { get; set; }

        [FindsBy(How = How.Id, Using = "user_login")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "user_password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How =How.Id, Using ="user_remember_me")]
        public IWebElement checkRememberMe { get; set; }

        public void Login(string userName, string password)
        {
            btnSignin.Click();
            txtUserName.EnterText(userName);
            txtPassword.EnterText(password);
            checkRememberMe.Click();

            btnLogin.ClickSubmit();            
        }
    }
}
