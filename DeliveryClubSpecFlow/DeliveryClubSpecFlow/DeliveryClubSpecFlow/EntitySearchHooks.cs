using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DeliveryClubSpecFlow
{
    [Binding]
    public sealed class EntitySearchHooks
    {
        [BeforeTestRun]
        public static void initChromeDriver()
        {
            DriverHolder.initDriver();
        }

        [BeforeTestRun]
        public static void initRunnedTags()
        {
            //RunnedListHolder.addScenarioToRunned("EntityPage");
            RunnedListHolder.addScenarioToIgnored("EntityPage");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Boolean shouldRunScenario = false;

            foreach (string scenarioTag 
                        in ScenarioContext.Current.ScenarioInfo.Tags)
            {
                if (RunnedListHolder.isScenarioInIgnored(scenarioTag))
                {
                    ScenarioContext.Current.Pending();
                }

                if (RunnedListHolder.isScenarioInRunned(scenarioTag))
                {
                    shouldRunScenario = true;
                }
            }

            if (!shouldRunScenario)
            {
                ScenarioContext.Current.Pending();
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
       }

        [AfterTestRun]
        public static void closeChromeDriver()
        {
            DriverHolder.closeDriver();
        }
    }
}
