using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeliveryClubTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace DeliveryClubSpecFlow
{
    [Binding]
    public sealed class EntitySearch
    {
        private DeliveryClubMainPageObject mainPage;
        private DeliveryClubEntityPageObject entityPage;

        [Given("Opened webpage https://(.*)")]
        public void openWebPage(string webPageUrl)
        {
            if (webPageUrl.Contains("delivery-club.ru"))
            {
                mainPage =
                    new DeliveryClubMainPageObject("https://" + webPageUrl,
                                               DriverHolder.getDriver());
            } else
            {
                ScenarioContext.Current.Pending();
                //либо повесить ошибку на hook
            }
        }

        [When("^I click to entity menu (.*)$")]
        public void clickToEntityMenu(string checkedMenu)
        {
            if(mainPage != null)
            {
                switch (checkedMenu)
                {
                    case "ALL":
                        entityPage = 
                            mainPage.clickOnEntitiesMenu(
                                DeliveryClubMainPageObject.MenuEntity.ALL);
                        break;
                }
            }
            else
            {
                ScenarioContext.Current.Pending();
            }
        }

        [Then("search results are")]
        public void searchResultsTest(Table table)
        {
            foreach(var row in table.Rows)
            {
                Assert.AreEqual(row[0]
                            , entityPage.resultElements[0].getHeaderText());
                Assert.AreEqual(row[1]
                                , entityPage.resultElements[0].getMinPrice());
            }
        }
    }
}
