using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;


namespace PracticeSpecFlowProj
{

    [Binding]
    public sealed class Hooks 
    {
        private IWebDriver driver;
        private readonly IObjectContainer objectContainer;
        private static string browserName;
        public static ExtentReports extentReports;
        public static ExtentTest extentTest;
        private string scenarioTitle, featureTite;
        private static string currentDirPath;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public static void SettingUpTestRun()
        {
            browserName = TestContext.Parameters.Get("browserName");
            string pathToCurrentDir = Directory.GetCurrentDirectory();
            currentDirPath = Path.GetDirectoryName(typeof(Hooks).Assembly.Location);
            Environment.CurrentDirectory = currentDirPath;
            // string pth = Assembly.GetCallingAssembly().;
            //   string pth = Assembly.GetCallingAssembly().CodeBase;
            //   string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            // string projPath = pathToCurrentDir.Substring(0,pathToCurrentDir.LastIndexOf("bin",StringComparison.Ordinal));
            string projPath = "D:\\Work\\ProjectCSharp\\PracticeSpecFlowProjSol\\PracticeSpecFlowProj\\";
            //  string projPath = new Uri(actualPath).LocalPath;
            string fileName = "SpecFlowProj_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".html";
            string reportPath = projPath + "Reports\\"+ fileName;

            extentReports = new ExtentReports(reportPath, true);
            extentReports.AddSystemInfo("User Name", "KSyed").AddSystemInfo("Environment", "QA")
                          .AddSystemInfo("Browser Name ",browserName);
            extentReports.LoadConfig(projPath + "extent-config.xml");
            browserName = TestContext.Parameters.Get("browserName");
            Console.WriteLine("++=====Before Test Run..!====++ > BrowserName :" + browserName);
        }
        [BeforeFeature]
        public static void beforeFeatureRun()
        {
         //   browserName = TestContext.Parameters.Get("browserName");
            Console.WriteLine("++=====Before Feature Run..!====++ > ");
            Console.WriteLine("=== >>> Feature Info Title :" + FeatureContext.Current.FeatureInfo.Title);
            Console.WriteLine("=== >>> Current Directory Path :" + currentDirPath);
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {   featureTite = FeatureContext.Current.FeatureInfo.Title;
            scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            extentTest = extentReports.StartTest(scenarioTitle, "Feature :" + featureTite);
            Console.WriteLine("=====Before Scenario..!==== > BrowserName :"+ browserName);
            ChooseDriver(browserName="Chrome");
            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
            Console.WriteLine("==>>> Scenario Info Title :" + scenarioTitle);
            Console.WriteLine("===> Scenario Info Tags :" + ScenarioContext.Current.ScenarioInfo.Tags);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null)
            { 
                var takesScreenshot = driver as ITakesScreenshot;
                string screenshotFileName = string.Format("{0}_{1}_{2}.png",FeatureContext.Current.FeatureInfo.Title,
                ScenarioContext.Current.ScenarioInfo.Title,DateTime.Now.ToString("dd_MM_yyy_HHmms"));
                    // string scrShotDir = Directory.GetCurrentDirectory() + @"\creenshots";
                string scrShotDir = "D:\\Work\\ProjectCSharp\\PracticeSpecFlowProjSol\\PracticeSpecFlowProj\\Screenshots\\";
                if (!Directory.Exists(scrShotDir))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"/Screenshots");
                }
                // string screenshotFilePath = TestFolders.GetOutputFilePath(screenshotFileName);
                string fullPathWithFile = Path.Combine(scrShotDir, screenshotFileName);
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile(fullPathWithFile, ScreenshotImageFormat.Png);
                Console.WriteLine("Screenshot: {0}", new Uri(fullPathWithFile));
                extentTest.Log(LogStatus.Fail, ScenarioContext.Current.TestError);
                extentTest.Log(LogStatus.Fail,  "Snapshot Below: " + extentTest.AddScreenCapture(fullPathWithFile));
             }
             else
            {
                extentTest.Log(LogStatus.Pass, "Test Passed..!");
            }
            Console.WriteLine("=====After Scenario..!====");
            driver.Quit();
        }

        [AfterTestRun]
        public static void AfterTestRun() {

            extentReports.Flush();
          //  extentReports.Close();
         
        }
        private void ChooseDriver(string browserName) {
            Console.WriteLine("+++++In ChooseDriver++++ >> BrowserName :" + browserName);
            if (browserName.ToLower() == "chrome")
            {
                driver = new ChromeDriver();
            }
            else {
                driver = new FirefoxDriver();
            }
        }
      
    }
}
