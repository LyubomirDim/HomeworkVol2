using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace LyubomirDimitrovHomework
{
    public class SearchTest
    {
        private ChromeDriver chrome;

        [SetUp]
        public void Setup()
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
        }

        [TearDown]
        public void CloseDriver()
        {
            chrome.Dispose();
        }

        public void NavigateToUrl(string url)
        {
            chrome.Url = url;
        }

        public IWebDriver GetDriver => chrome;

        [Test]
        public void CheckIfGoogleSearchDisplaysResultsPage()
        {
            Webpage page = new Webpage(chrome);
            NavigateToUrl(page.googleUrl);

            page.EnterTextInSearchArea(page.mySearchText);
            page.ClickSearchButton();

            Thread.Sleep(2000);

            Assert.IsTrue(page.SearchPageIsDisplayedSuccessfully());
        }
    }
}
