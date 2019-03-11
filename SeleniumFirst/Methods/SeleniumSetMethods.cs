using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        /// <summary>
        /// Extended method for enterng text in the control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        /// <summary>
        /// Click into a button, checkbox, and etc
        /// </summary>
        /// <param name="element"></param>
        public static void Click(this IWebElement element)
        {
            element.Click();
        }
        /// <summary>
        /// Selecting a dropdown menu
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>

        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
            //new SelectElement(element).SelectByValue(value);
        }
        public static void ClickSubmit(this IWebElement element)
        {
            element.Submit();
        }
    }
}

