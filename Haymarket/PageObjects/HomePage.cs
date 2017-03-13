using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Threading;

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
            Thread.Sleep(10000);
            Reference.driver.FindElement(By.XPath("//*[@id='tab1']/form/div[2]/div[4]/span/input")).SendKeys(Keys.Enter);
        }

        public void ClickBikeSearch()
        {
            Thread.Sleep(10000);
            Reference.driver.FindElement(By.XPath("//*[@id='tab2']/form/div[2]/div[4]/span/input")).SendKeys(Keys.Enter);
        }

        public void BikesTab()
        {
            Reference.driver.FindElement(By.XPath("html/body/div/div[4]/div[3]/div[2]/div[1]/ul/li[2]/a")).Click();
        }

        public void SearchForBike(string bikemake)
        {
            Reference.driver.FindElement(By.Id("Bike-MakesDropdown")).Click();

            var bikemodeldrop = Reference.driver.FindElement(By.Id("Bike-MakesDropdown"));
            SelectElement sebikemodel = new SelectElement(bikemodeldrop);
            sebikemodel.SelectByText(bikemake);
        }

        public void MaxBikePrice(string price)
        {
            Reference.driver.FindElement(By.Id("Bike-MaxPrice")).Click();

            var bikepricedrop = Reference.driver.FindElement(By.Id("Bike-MaxPrice"));
            SelectElement sebikeprice = new SelectElement(bikepricedrop);
            sebikeprice.SelectByText(price);
        }

    }
}
