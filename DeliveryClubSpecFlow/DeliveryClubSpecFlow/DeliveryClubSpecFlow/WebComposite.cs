using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DeliveryClubTests
{
    public abstract class WebComposite
    {
        protected IWebElement fromElement;
        protected string id;
        protected string name;

        protected WebComposite(IWebElement fromElement)
        {
            this.fromElement = fromElement ?? throw new ArgumentNullException(nameof(fromElement));

            //this.id = fromElement.GetAttribute("id") ?? "";
            //this.name = fromElement.GetAttribute("name") ?? "";
        }
    }
}
