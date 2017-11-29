using SeleniumNUnitProj.main;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumNUnitProj.PageObject
{
   public class MainPage //: WaitCommonClass
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='cssmenu']//span[text()='Logout']")]
        public IWebElement LogOutMenuLink;

        [FindsBy(How = How.XPath, Using = "//body/h1[contains(text(),'Execute Automation')]")]
        public IWebElement MainHeading;

        [FindsBy(How = How.XPath, Using = "//form[@id='details']//a[@href='popup.html']")]
        public IWebElement HtmlPopupLink;

        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement InitialTxtBox;

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstNameTxtBox;

        [FindsBy(How = How.Id, Using = "MiddleName")]
        public IWebElement MiddleNameTxtBox;

        [FindsBy(How = How.Name, Using = "generate")]
        public IWebElement GenerateAlertButton;


        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //public IWebElement LogOutMenuLink() {
        //    return WaitElementToBeVisible(driver, By.XPath("//div[@id='cssmenu']//span[text()='Logout']"));
        //}

        //public IWebElement MainHeading()
        //{
        //    return WaitElementToBeVisible(driver, By.XPath("//body/h1[contains(text(),'Execute Automation')]"));
        //}

        //public IWebElement HtmlPopupLink()
        //{
        //    return WaitElementToBeVisible(driver, By.XPath("//form[@id='details']//a[@href='popup.html']"));
        //}

        //public IWebElement GenerateAlertButton()
        //{
        //    return WaitElementToBeVisible(driver, By.Name("generate"));
        //}

    }
}
