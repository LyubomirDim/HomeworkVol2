using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LyubomirDimitrovHomework
{
    class Webpage
    {
        public string googleUrl = "https://www.google.com/";
        public string searchResultPageUrl = "https://www.google.com/search?source=hp&ei=fxSGXvyWGNTUmwXj1YLwAQ&q=asd&oq=asd&gs_lcp=CgZwc3ktYWIQAzICCAAyBQgAEIMBMgIIADICCAAyAggAMgQIABAKMgIIADICCAAyAggAMgIIAFCsuJgBWMvEmAFgxtOZAWgAcAB4AIABXYgB1QKSAQE0mAEAoAEBqgEHZ3dzLXdperABAA&sclient=psy-ab&ved=0ahUKEwi80pOylsroAhVU6qYKHeOqAB4Q4dUDCAY&uact=5";
        public string mySearchText = "asd";
        readonly By searchTextArea = By.Name("q");
        readonly By googleSearchButton = By.Name("btnK");
        readonly By googleOptionsButton = By.Id("abar_button_opt");
        private IWebDriver webDriver;

        public Webpage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void GoToSite(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public void EnterTextInSearchArea(string searchText)
        {
            webDriver.FindElement(searchTextArea).Clear();
            webDriver.FindElement(searchTextArea).SendKeys(searchText);
        }

        public void ClickSearchButton()
        {
            webDriver.FindElement(googleSearchButton).Click();
        }

        public bool SearchPageIsDisplayedSuccessfully()
        {
            return webDriver.FindElement(googleOptionsButton).Displayed;
        }
    }
}
