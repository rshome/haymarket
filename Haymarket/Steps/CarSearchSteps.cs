using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Haymarket;

namespace Haymarket.Steps
{
    [Binding]
    public class CarSearchSteps
    {
        HomePage home = new HomePage();

        [BeforeScenario]
        public void setUp()
        {
            Reference.Initialize();
        }

        [AfterScenario]
        public void TearDown()
        {
            Reference.Quit();
        }


        [Given(@"a user is on the PistonHeads home page")]
        public void GivenAUserIsOnThePistonHeadsHomePage()
        {
            Reference.GotoUrl();
            Reference.MaximiseWindow();
            Reference.ClearCookies();
        }
        
        [When(@"a make of (.*) is selected in the advert search widget")]
        public void WhenAMakeOfIsSelectedInTheAdvertSearchWidget(string make)
        {
            home.SearchForMake(make);
        }
        
        [When(@"a model of (.*) is selected in the advert search widget")]
        public void WhenAModelOfIsSelectedInTheAdvertSearchWidget(string model)
        {
            Reference.WaitForPage();
            home.SearchForModel(model);
        }
        
        [When(@"the Search button is clicked in the advert search widget")]
        public void WhenTheSearchButtonIsClickedInTheAdvertSearchWidget()
        {
            home.ClickSearch();
        }
        
        [Then(@"the number of advert search results is greater than (.*)")]
        public void ThenTheNumberOfAdvertSearchResultsIsGreaterThan(int p0)
        {
            Reference.WaitForPage();
            String results = Reference.driver.FindElement(By.Id("search-numfound")).Text;

            int count = Convert.ToInt32(results);

            Assert.IsTrue(count > 0);            
        }

        
    }
}
