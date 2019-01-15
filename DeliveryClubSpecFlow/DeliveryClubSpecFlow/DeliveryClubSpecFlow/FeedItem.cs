using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DeliveryClubTests
{
    public class FeedItem : WebComposite
    {
        private IWebElement image;
        private IWebElement header;
        private IWebElement link;
        private IWebElement comment;
        private string backgroundUrl;

        private const string FEED_LIVE_ITEM_PATH = @"//ul[@id='feed-live']/li";
        private const string FEED_IMG_PATH = FEED_LIVE_ITEM_PATH + @"/div[contains(@class, 'wrapper-img')]/a";
        private const string FEED_LIVE_ITEM_CONTENT_PATH = FEED_LIVE_ITEM_PATH + @"/div[contains(@class, 'content')]/div/div";
        private const string FEED_HEADER_PATH = FEED_LIVE_ITEM_CONTENT_PATH + @"/p[contains(@class, 'sub')]/preceding-sibling::p";
        private const string FEED_LINK_PATH = FEED_LIVE_ITEM_CONTENT_PATH + @"/p/a";
        private const string FEED_COMMENT_PATH = FEED_LIVE_ITEM_CONTENT_PATH + @"/p[contains(@class, 'sub')]";
        private const string FEED_CONTENT = @"//div[@class='content']";

        public FeedItem(IWebElement fromElement) : base(fromElement)
        {
            image = fromElement.FindElement(By.XPath(FEED_IMG_PATH));
            header = fromElement.FindElement(By.XPath(FEED_HEADER_PATH));
            try
            {
                link = fromElement.FindElement(By.XPath(FEED_LINK_PATH));
            }
            catch(Exception ex)
            {
                link = null;
            }
            comment = fromElement.FindElement(By.XPath(FEED_COMMENT_PATH));
            backgroundUrl = fromElement.FindElement(By.XPath(FEED_CONTENT)).GetCssValue("background");
        }
    }
}
