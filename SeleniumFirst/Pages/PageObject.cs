using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst.Pages
{
    class PageObject
    {
        public PageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "feedback")]
        public IWebElement feedbackButton { get; set; }

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement txtName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "subject")]
        public IWebElement txtSubject { get; set; }

        [FindsBy(How = How.Id, Using = "comment")]
        public IWebElement txtComment { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div/form/div[2]/input[1]")]
        public IWebElement btnSend { get; set; }

        public void FillUserForm(string name, string email, string subject, string comment)
        {
            txtName.EnterText(name);
            txtEmail.EnterText(email);
            txtSubject.EnterText(subject);
            txtComment.EnterText(comment);
        }
    }
}
