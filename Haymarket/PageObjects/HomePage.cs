using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Haymarket
{
    public class HomePage
    {
        public void SearchForMake(string make)
        {
            Reference.driver.FindElement(By.Id("Car-MakesDropdown")).Click();

            var makedrop = Reference.driver.FindElement(By.Id("Car-MakesDropdown"));
            SelectElement semake = new SelectElement(makedrop);
            semake.SelectByText(make);
        }

        public void SearchForModel(string model)
        {
            Reference.driver.FindElement(By.Id("Car-ModelsDropdown")).Click();

            var modeldrop = Reference.driver.FindElement(By.Id("Car-ModelsDropdown"));
            SelectElement semodel = new SelectElement(modeldrop);
            semodel.SelectByText(model);
        }

        public void ClickSearch()
        {            
            Reference.driver.FindElement(By.XPath("//*[@id='tab1']/form/div[2]/div[4]/span/input")).SendKeys(Keys.Enter);
        }

        public void BikesTab()
        {
            Reference.driver.FindElement(By.ClassName("button button--primary")).Click();
        }

        public void SearchForBike(string bikemake)
        {
            var bikemodeldrop = Reference.driver.FindElement(By.Id("Bike-MakesDropdown"));
            SelectElement sebikemodel = new SelectElement(bikemodeldrop);
            sebikemodel.SelectByText(bikemake);
        }

        public void MaxBikePrice(string price)
        {
            var bikepricedrop = Reference.driver.FindElement(By.Id("Bike-MaxPrice"));
            SelectElement sebikeprice = new SelectElement(bikepricedrop);
            sebikeprice.SelectByText(price);
        }

    }
}
