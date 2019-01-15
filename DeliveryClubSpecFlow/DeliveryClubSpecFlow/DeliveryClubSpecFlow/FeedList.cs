using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DeliveryClubTests
{
    public class FeedList : WebComposite
    {
        public List<FeedItem> feedItems;
        private const string FEED_LIVE_ITEM_PATH = @"//ul[@id='feed-live']/li";

        public FeedList(IWebElement fromElement) : base(fromElement)
        {
            feedItems = new List<FeedItem>();
            foreach(IWebElement feedItemElement in
                        fromElement.FindElements(By.XPath(FEED_LIVE_ITEM_PATH)))
            {
                FeedItem feedItem = new FeedItem(feedItemElement);
                feedItems.Add(feedItem);
            }
        }
    }
}
