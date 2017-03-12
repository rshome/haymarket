using System;
using TechTalk.SpecFlow;
using Haymarket.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;


namespace Haymarket
{
    [Binding]
    public class BikeAdvertSteps 
    {
        HomePage homebike = new HomePage();

        [When(@"the Bikes tab is selected in the advert search widget")]
        public void WhenTheBikesTabIsSelectedInTheAdvertSearchWidget()
        {
            Reference.WaitForPage();
            homebike.BikesTab();            
        }
        
        [When(@"a bike make of Ducati is selected in the advert search widget")]
        public void WhenABikeMakeOfDucatiIsSelectedInTheAdvertSearchWidget(string bikemake)
        {
            Reference.WaitForPage();
            homebike.SearchForBike(bikemake);
        }
        
        [When(@"a max price of (.*) pounds is selected in the advert search widget")]
        public void WhenAMaxPriceOfPoundsIsSelectedInTheAdvertSearchWidget(string price)
        {
            Reference.WaitForPage();
            homebike.MaxBikePrice(price);
        }
        
        [Then(@"the make Ducati is selected in the Refine Your Search side panel")]
        public void ThenTheMakeDucatiIsSelectedInTheRefineYourSearchSidePanel()
        {
            Reference.WaitForPage();

            Assert.AreEqual("Ducati", Reference.driver.FindElement(By.Id("MakeDropdown")).Text);
        }
    }
}
