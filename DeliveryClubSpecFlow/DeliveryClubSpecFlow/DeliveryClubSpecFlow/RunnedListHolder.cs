using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryClubSpecFlow
{
    public class RunnedListHolder
    {
        private static List<string> runnedScenarios = new List<string>();
        private static List<string> ignoredScenarios = new List<string>();

        public static void addScenarioToRunned(string tagName)
        {
            runnedScenarios.Add(tagName);
            ignoredScenarios.Remove(tagName);
        }

        public static void addScenarioToIgnored(string tagName)
        {
            ignoredScenarios.Add(tagName);
            runnedScenarios.Remove(tagName);
        }

        public static Boolean isScenarioInRunned(string tagName)
        {
            return runnedScenarios.Contains(tagName);
        }

        public static Boolean isScenarioInIgnored(string tagName)
        {
            return ignoredScenarios.Contains(tagName);
        }
    }
}
