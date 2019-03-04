using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst.Pages
{
    class AccountSummaryPage
    {
        public AccountSummaryPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div[2]/div/div/div[1]/div/table/tbody/tr[1]/td[1]/a")]
        public IWebElement btnSavings { get; set; }

        [FindsBy(How = How.Id, Using = "aa_accountId")]
        public IWebElement ddmAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='aa_accountId']/option[2]")]
        public IWebElement optChecking { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.Id, Using = "user_remember_me")]
        public IWebElement checkRememberMe { get; set; }

        public void CheckingOption()
        {            
            SeleniumSetMethods.SelectDropDown(ddmAccount, "Checking");
        }
    }
}
