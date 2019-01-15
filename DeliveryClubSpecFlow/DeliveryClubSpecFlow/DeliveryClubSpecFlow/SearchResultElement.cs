using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DeliveryClubTests
{
    public class SearchResultElement : WebComposite
    {
        private IWebElement resultHeader;
        private IWebElement resultMinPrice;

        private const string HEADER_PATH_IN_RESULT = 
            "//section[@class='vendor-item__title']/a/span";
        private const string MIN_PRICE_PATH_IN_RESULT =
            "//section[@class='vendor-item-info']/div[@class='vendor-item-info__min-order']/div[@class='vendor-item-info__value']";

        public SearchResultElement(IWebElement fromElement) : base(fromElement)
        {
            resultHeader = fromElement.FindElement(By.XPath(HEADER_PATH_IN_RESULT));
            resultMinPrice = fromElement.FindElement(By.XPath(MIN_PRICE_PATH_IN_RESULT));
        }

        public string getHeaderText()
        {
            return resultHeader.Text;
        }

        public string getMinPrice()
        {
            return resultMinPrice.Text;
        }
    }
}
