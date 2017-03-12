using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;

namespace Haymarket
{
    public class Reference
    {

        public static string BaseAddress
        {
            get { return "http://www.pistonheads.com"; }
        }

        public static IWebDriver driver { get; set; }


        public static void Initialize()
        {
            driver = new FirefoxDriver();
        }

        public static void GotoUrl()
        {
            //Go to PistonHeads Homepage
            driver.Navigate().GoToUrl(BaseAddress);
        }

        public static void MaximiseWindow()
        {
            //Maximise browser window
            driver.Manage().Window.Maximize();
        }

        public static void ClearCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        public static void Quit()
        {
            driver.Quit();
        }

        public static void WaitForPage()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }


    }
}

