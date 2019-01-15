using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DeliveryClubSpecFlow
{
    public class DriverHolder
    {
        private static IWebDriver driver;

        public static void initDriver()
        {
            driver = new ChromeDriver(@"C:\temp\");
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }

        public static void closeDriver()
        {
            driver.Close();
        }
    }
}
