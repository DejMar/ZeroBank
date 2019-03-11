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

        [FindsBy(How = How.Id, Using = "transfer_funds_tab")]
        public IWebElement btnTransferFunds { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='account_activity_tab']/a")] 
        public IWebElement btnAccountActivity { get; set; }

        [FindsBy(How = How.Id, Using = "tf_fromAccountId")]
        public IWebElement optFromAccount { get; set; }

        [FindsBy(How = How.Id, Using = "tf_toAccountId")]
        public IWebElement optToAccount { get; set; }

        [FindsBy(How = How.Id, Using = "tf_amount")]
        public IWebElement txtAmount { get; set; }

        [FindsBy(How = How.Id, Using = "tf_description")]
        public IWebElement txtDescription { get; set; }

        [FindsBy(How = How.Id, Using = "btn_submit")]
        public IWebElement btnContinue { get; set; }

        [FindsBy(How = How.ClassName, Using = "board-header")]
        public IWebElement msgExpected { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='transfer_funds_content']/div/a")]
        public IWebElement btnAnotherTransfer { get; set; }

        //Pay Bill - Pay Saved Payee

        [FindsBy(How = How.Id, Using = "pay_bills_tab")]
        public IWebElement btnBillPay { get; set; }

        [FindsBy(How = How.Id, Using = "sp_payee")]
        public IWebElement ddmPayee { get; set; }

        [FindsBy(How = How.Id, Using = "sp_account")]
        public IWebElement ddmSpAccount { get; set; }

        [FindsBy(How = How.Id, Using = "sp_amount")]
        public IWebElement txtSpAmount { get; set; }

        [FindsBy(How = How.Id, Using = "sp_date")]
        public IWebElement txtSpDate { get; set; }

        [FindsBy(How = How.Id, Using = "sp_description")]
        public IWebElement txtSpDescription { get; set; }
        
        [FindsBy(How = How.Id, Using = "pay_saved_payees")]
        public IWebElement btnPay { get; set; }

        [FindsBy(How =How.XPath, Using = "//*[@id='alert_content']/span")]
        public IWebElement msgPayment { get; set; }

        //Pay Bill - Add New Payee 

        [FindsBy(How = How.XPath, Using = "//*[@id='tabs']/ul/li[2]/a")]
        public IWebElement btnAddNewPayee { get; set; }

        [FindsBy(How = How.Id, Using = "np_new_payee_name")]
        public IWebElement txtPayeeName { get; set; }

        [FindsBy(How = How.Id, Using = "np_new_payee_address")]
        public IWebElement txtPayeeAddress { get; set; }

        [FindsBy(How = How.Id, Using = "np_new_payee_account")]
        public IWebElement txtPayeeAccount { get; set; }

        [FindsBy(How = How.Id, Using = "np_new_payee_details")]
        public IWebElement txtPayeeDetails { get; set; }

        [FindsBy(How = How.Id, Using = "add_new_payee")]
        public IWebElement btnAddPayee { get; set; }

        [FindsBy(How = How.Id, Using = "alert_content")]
        public IWebElement msgAddNewPayee { get; set; }

        [FindsBy(How = How.ClassName, Using = "board-header")]//*[@id='ui - tabs - 2']/h2
        public IWebElement lblHeaderAddNewPayee { get; set; }

        //Pay Bill - Purchase Foreign Currency

        




        //Find Transactions

        [FindsBy(How = How.XPath, Using = "//*[@id='tabs']/ul/li[2]/a")]
        public IWebElement btnFindTransactions { get; set; } 

        [FindsBy(How = How.Id, Using = "aa_description")]
        public IWebElement txtAaDescription { get; set; }

        [FindsBy(How = How.Id, Using = "aa_fromDate")]
        public IWebElement txtAaFromDate { get; set; }

        [FindsBy(How = How.Id, Using = "aa_toDate")]
        public IWebElement txtAaToDate { get; set; }

        [FindsBy(How = How.Id, Using = "aa_fromAmount")]
        public IWebElement txtAaFromAmount { get; set; }

        [FindsBy(How = How.Id, Using = "aa_toAmount")]
        public IWebElement txtAaToAmount { get; set; }

        [FindsBy(How = How.Id, Using = "aa_type")]
        public IWebElement ddmAaType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='find_transactions_form']/div[2]/button")]
        public IWebElement btnFind { get; set; }


        public void CheckingOption()
        {            
            SeleniumSetMethods.SelectDropDown(ddmAccount, "Savings");
        }

        public void FillTransferMoneyAndMakePayment(string FromAcc, string ToAcc, string Amount, string Description)
        {
            SeleniumSetMethods.SelectDropDown(optFromAccount, FromAcc);
            SeleniumSetMethods.SelectDropDown(optToAccount, ToAcc);
            SeleniumSetMethods.EnterText(txtAmount, Amount);
            SeleniumSetMethods.EnterText(txtDescription, Description);
        }

        public void PopulatePaymentToSavedPayees(string Payee, string Account, string Amount, string Date, string Description)
        {
            SeleniumSetMethods.SelectDropDown(ddmPayee, Payee);
            SeleniumSetMethods.SelectDropDown(ddmSpAccount, Account);
            SeleniumSetMethods.EnterText(txtSpAmount, Amount);
            SeleniumSetMethods.EnterText(txtSpDate, Date);
            AccountSummaryPage page = new AccountSummaryPage();
            page.txtSpAmount.Click();
            SeleniumSetMethods.EnterText(txtSpDescription, Description);            
        }

        public void PopulateAddNewPayeeForm(string PayeeName, string PayeeAddress, string PayeeAccount, string PayeeDetails)
        {
            SeleniumSetMethods.EnterText(txtPayeeName, PayeeName);
            SeleniumSetMethods.EnterText(txtPayeeAddress, PayeeAddress);
            SeleniumSetMethods.EnterText(txtPayeeAccount, PayeeAccount);
            SeleniumSetMethods.EnterText(txtPayeeDetails, PayeeDetails);
        }

        public void PopulateFindTransactionsForm(string Description, string FromDates, string ToDates, string FromAmount, string ToAmount, string Type)
        {
            SeleniumSetMethods.EnterText(txtAaDescription, Description);
            SeleniumSetMethods.EnterText(txtAaFromDate, FromDates);
            SeleniumSetMethods.EnterText(txtAaToDate, ToDates);
            SeleniumSetMethods.EnterText(txtAaFromAmount, FromAmount);
            SeleniumSetMethods.EnterText(txtAaToAmount, ToAmount);
            SeleniumSetMethods.SelectDropDown(ddmAaType, Type);
        }

    }
}
