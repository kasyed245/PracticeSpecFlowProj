using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumNUnitProj.main;

namespace PracticeSpecFlowProj.PageObject
{
   public class BasePage
    {
        public IWebDriver driver;
        protected Helper helper;
        public static BasePage Instance;
        public BasePage(IWebDriver driverInstance)
        {
            driver = driverInstance;
            PageFactory.InitElements(driver, this);
            //return pageClass;
        }

        public void InitiateHelper() {
            helper = new Helper(driver);
        }


    }
}
