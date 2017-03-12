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
            var modeldrop = Reference.driver.FindElement(By.Id("Car-ModelsDropdown"));
            SelectElement semodel = new SelectElement(modeldrop);
            semodel.SelectByText(model);
        }

        public void ClickSearch()
        {
            Reference.driver.FindElement(By.XPath("//*[@id='tab1']/form/div[2]/div[4]/span/input")).Click();          
        }

        public void BikesTab()
        {
            Reference.driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div[3]/div[2]/div[1]/ul/li[2]/a")).Click();
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
