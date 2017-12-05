using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumNUnitProj.PageObject;
using TechTalk.SpecFlow;
using PracticeSpecFlowProj.PageObject;

namespace PracticeSpecFlowProj
{
    public class BaseStep :Steps
    {
        public IWebDriver driver;
        public LoginPage loginPage;
        public MainPage mainPage;

        
        public BaseStep(IWebDriver driver) {
            this.driver = driver;
            loginPage = new LoginPage(driver);
            //            loginPage = InstanceOf<LoginPage>(driver);  
            mainPage = new MainPage(driver);

        }


    }
}
