using SeleniumNUnitProj.main;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumNUnitProj.PageObject
{

    public class PopupWindow //: WaitCommonClass
    {
        [FindsBy(How = How.XPath, Using = "//body/p[contains(text(),'demo popup')]")]
        public IWebElement SubHeadingPopup;

        [FindsBy(How = How.XPath, Using = "//body/h1[contains(text(),'Execute Automation')]")]
        public IWebElement MainHeadingPopup;


        private IWebDriver driver;

        public PopupWindow(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //public IWebElement SubHeadingPopup() {
        //    return WaitElementToBeVisible(driver, By.XPath("//body/p[contains(text(),'demo popup')]"));
        //}

        //public IWebElement MainHeadingPopup()
        //{
        //    return WaitElementToBeVisible(driver, By.XPath("//body/h1[contains(text(),'Execute Automation')]"));
        //}

    }
}
