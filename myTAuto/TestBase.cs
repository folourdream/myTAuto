using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace myTAuto
{

    [TestFixture]
    public abstract class TestBase
    {

        internal static IWebDriver driver;


        [SetUp]
        public void TestSetup()

        {
            
           
            driver.Navigate().GoToUrl("http://www.toyota.com.au/myToyota");
        }



        [TearDown]
        public void TestCleanUp()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }




        public static void BeginExecution()
        {


            driver = new ChromeDriver();
            //new ChromeDriver(@"/Users/ranjeet/Projects/myTAuto/");
            driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(20));
            driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromSeconds(20));
            driver.Manage().Window.Maximize();
        }




        public static void ExitExecution()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}