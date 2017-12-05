using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SeleniumNUnitProj.main
{
   public class WaitCommonClass
    {   private const int WAiT_TIME =10;
        protected  IWebDriver driver;

        public WaitCommonClass(IWebDriver driver) => this.driver = driver;
       

        public IWebElement WaitElementToBeVisible(By by,double waitTime= WAiT_TIME)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public IWebElement WaitElementToBeExists(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAiT_TIME));
            return wait.Until(ExpectedConditions.ElementExists(by));
        }

        public IWebElement WaitElementToBeClickable(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAiT_TIME));
            return wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public IList<IWebElement> waitElementsToBeExist(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAiT_TIME));
            return wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
        }

    }
}
