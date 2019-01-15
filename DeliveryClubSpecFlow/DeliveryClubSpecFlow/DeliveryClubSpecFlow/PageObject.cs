using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DeliveryClubTests
{
    public abstract class PageObject
    {
        protected string title;
        protected string currentUrl;
        protected IWebDriver driver;

        protected PageObject(string currentUrl, IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            moveToUrl(currentUrl);
            this.currentUrl = currentUrl ?? throw new ArgumentNullException(nameof(currentUrl));
        }

        protected PageObject(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        protected PageObject moveToUrl(string newUrl)
        {
            if(newUrl == null)
            {
                throw new ArgumentNullException("url must be not null");
            }

            if (!newUrl.Equals(this.currentUrl))
            {
                driver.Navigate().GoToUrl(newUrl);
                this.currentUrl = newUrl;
                this.title = driver.Title;
            }
            else
            {
                driver.Navigate().Refresh();
            }

            return this;
        }
    }
}
