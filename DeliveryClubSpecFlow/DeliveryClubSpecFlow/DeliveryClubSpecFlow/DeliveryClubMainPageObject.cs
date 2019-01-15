using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DeliveryClubTests
{
    public class DeliveryClubMainPageObject : PageObject
    {
        private const string FEED_LIVE_ID = "feed-live";
        private const string MENU_ENTITY_PATH = 
            "//div[@id='wrapper-menu']/a[contains(@class, '{0}')]";
        private const string MENU_ALL_PATH = 
            "//div[@id='wrapper-menu']/a/span/text()[contains(.,'Все рестораны')]/parent::span/parent::a";
        
        public FeedList feedList;

        public enum MenuEntity{
            ALL,
            PIZZA,
            SUSHI,
            MEAT,
            PIKES,
            BURGERS
        }
        
        public DeliveryClubMainPageObject(string currentUrl, IWebDriver driver) : base(currentUrl, driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("return window.stop();");

            //feedList = new FeedList(driver.FindElement(By.Id(FEED_LIVE_ID)));
        }

        public DeliveryClubEntityPageObject clickOnEntitiesMenu(MenuEntity choice)
        {
            IWebElement menuItemToClick = null;
            switch (choice)
            {
                case MenuEntity.ALL:
                    menuItemToClick = driver.FindElement(By.XPath(MENU_ALL_PATH));
                    break;
                case MenuEntity.BURGERS:
                    menuItemToClick =
                        driver.FindElement(
                                        By.XPath(
                                                String.Format(MENU_ENTITY_PATH, "burger")
                                            )
                                    );
                    break;
                case MenuEntity.MEAT:
                    menuItemToClick =
                        driver.FindElement(
                                        By.XPath(
                                                String.Format(MENU_ENTITY_PATH, "shashliki")
                                            )
                                    );
                    break;
                case MenuEntity.PIKES:
                    menuItemToClick =
                        driver.FindElement(
                                        By.XPath(
                                                String.Format(MENU_ENTITY_PATH, "pirogi")
                                            )
                                    );
                    break;
                case MenuEntity.PIZZA:
                    menuItemToClick =
                        driver.FindElement(
                                        By.XPath(
                                                String.Format(MENU_ENTITY_PATH, "pizza")
                                            )
                                    );
                    break;
                case MenuEntity.SUSHI:
                    menuItemToClick =
                        driver.FindElement(
                                        By.XPath(
                                                String.Format(MENU_ENTITY_PATH, "sushi")
                                            )
                                    );
                    break;
            }

            String newUrl = menuItemToClick.GetAttribute("href");

            if (menuItemToClick != null)
            {
                menuItemToClick.Click();
            }

            //return new DeliveryClubEntityPageObject(newUrl, driver);
            return new DeliveryClubEntityPageObject(driver.Url, driver);
        }
    }
}
