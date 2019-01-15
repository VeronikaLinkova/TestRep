using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DeliveryClubTests
{
    public class DeliveryClubEntityPageObject : PageObject
    {
        private string HEADER_PATH =
            @"//ul/li[@class='vendor-item']/*/div[@class='vendor-item__content']/section[@class='vendor-item__title']/a/span";
        private string MIN_PRICE_PATH =
            @"//div[@class='vendor-list__container']/descendant::li[@class='vendor-item'][1]/descendant::div[@class='vendor-item-info__value'][1]";

        private string RESULT_ELEM_PATH =
            @"//div[@class='vendor-item__content']";

        public List<SearchResultElement> resultElements;

        public DeliveryClubEntityPageObject(string currentUrl, IWebDriver driver) : base(currentUrl, driver)
        {
            resultElements = new List<SearchResultElement>();
            foreach(IWebElement webElement 
                in driver.FindElements(By.XPath(RESULT_ELEM_PATH)))
            {
                SearchResultElement searchResult =
                    new SearchResultElement(webElement);
                resultElements.Add(searchResult);
            }
        }
    }
}
