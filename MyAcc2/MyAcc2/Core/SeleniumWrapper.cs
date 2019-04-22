using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyAcc2.Core
{
    public class SeleniumWrapper
    {
        protected  IWebDriver Driver = new ChromeDriver();
        
        protected  void OpenPage(string page)
        {
            Driver.Navigate().GoToUrl(page);
        }

        protected  void RefreshPage()
        {
            Driver.Navigate().Refresh();
        }

        protected IWebElement FindElement(By locator)
        {
            return Driver.FindElement(locator);
        }
    }
}
