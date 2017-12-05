using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumNUnitProj.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;


namespace PracticeSpecFlowProj.StepDefinition
{
    [Binding]
    public class RegisterFormSteps :BaseStep
    {
        //LoginPage loginPage;
        //MainPage mainPage;

        //private IWebDriver driver;
        //public RegisterFormSteps(IWebDriver driver)  {
        //    this.driver = driver;
        //    loginPage = new LoginPage(driver);
        //    mainPage = new MainPage(driver);

        //}
        public RegisterFormSteps(IWebDriver driver) : base(driver) { }

        [When(@"I enter intial (.*), FirstName (.*) and LastName (.*)")]
        public void WhenIEnterIntialKFirstNameHelloAndLastNameWorld(string initial,string fName, string lName)
        {
            Console.WriteLine("**I enter initial, firtName, LastName ***");
            mainPage.InitialTxtBox.SendKeys(initial);
            mainPage.FirstNameTxtBox.SendKeys(fName);
            mainPage.MiddleNameTxtBox.SendKeys(lName);
            //driver.FindElement(By.Id("Initial")).SendKeys(initial);
            //driver.FindElement(By.Id("FirstName")).SendKeys(fName);
            //driver.FindElement(By.Id("MiddleName")).SendKeys(lName);
            Thread.Sleep(1000);
           // Assert.IsTrue(fName.Contains("Hello"));
            //Console.WriteLine("Initial :" + initial);
            //Console.WriteLine("FName :" + fName);
            //Console.WriteLine("LName :" + lName);
            Given("I goto login page");
            Thread.Sleep(2000);
            When("I press login button");
        }

              [When(@"I press register button")]
        public void WhenIPressRegisterButton()
        {
            Thread.Sleep(1000);
            string fNameTxt = mainPage.FirstNameTxtBox.GetAttribute("value");
            Console.WriteLine("FirstName :" + fNameTxt);
          //  Assert.IsTrue(fNameTxt.Contains("Jack"));
            Console.WriteLine("** I press Register button ***");
        }
    }
}
