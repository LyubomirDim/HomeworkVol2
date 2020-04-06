using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace LyubomirDimitrovHomework
{
    [Binding]
    public class CheckIfGoogleSearchDisplaysResultPage
    {
        ChromeDriver driver = new ChromeDriver();
        [Given(@"I am on google\.com")]
        public void GivenIAmOnGoogle_Com()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Given(@"I have entered aa value in the search text area")]
        public void GivenIHaveEnteredAaValueInTheSearchTextArea()
        {
            driver.FindElementByName("q").Clear();
            driver.FindElementByName("q").SendKeys("asd");
        }

        [When(@"I press Google Search")]
        public void WhenIPressGoogleSearch()
        {
            driver.FindElementByName("btnK").Click();
        }

        [Then(@"I should be redirected to the results page")]
        public void ThenIShouldBeRedirectedToTheResultsPage()
        {
            driver.Navigate().GoToUrl("https://www.google.com/search?source=hp&ei=fxSGXvyWGNTUmwXj1YLwAQ&q=asd&oq=asd&gs_lcp=CgZwc3ktYWIQAzICCAAyBQgAEIMBMgIIADICCAAyAggAMgQIABAKMgIIADICCAAyAggAMgIIAFCsuJgBWMvEmAFgxtOZAWgAcAB4AIABXYgB1QKSAQE0mAEAoAEBqgEHZ3dzLXdperABAA&sclient=psy-ab&ved=0ahUKEwi80pOylsroAhVU6qYKHeOqAB4Q4dUDCAY&uact=5");
            var result = driver.FindElementById("abar_button_opt").Displayed;
        }
    }
}
