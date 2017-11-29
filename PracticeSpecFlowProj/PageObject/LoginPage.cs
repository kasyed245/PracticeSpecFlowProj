using SeleniumNUnitProj.main;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumNUnitProj.PageObject
{
    public class LoginPage //: WaitCommonClass
    {   [FindsBy(How=How.Name,Using="UserName")]
        public IWebElement UserNameTextBox;

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement PasswordTextBox;

        [FindsBy(How = How.XPath, Using = "//form[@id='userName']//input[@name='Login']")]
        public IWebElement LoginButton;

        private IWebDriver driver;

        public LoginPage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //public IWebElement UserNameTextBox() {
        //    return WaitElementToBeVisible(driver, By.Name("UserName"));
        //}

        //public IWebElement PasswordTextBox()
        //{
        //   // return WaitElementToBeVisible(driver, By.Name("Password"));
        //    return driver.FindElement(By.Name("Password"));
        //}

        //public IWebElement LoginButton()
        //{
        //    //return WaitElementToBeVisible(driver, By.XPath("//form[@id='userName']//input[@name='Login']"));
        //    return driver.FindElement(By.XPath("//form[@id='userName']//input[@name='Login']"));
        //}


    }
}
