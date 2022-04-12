using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99Demo
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\3rdparty\\chrome");

        }

        [Test]
        public void test()
        {
            driver.Url = "http://https://www.accuweather.com/en/za/cape-town/306633/weather-forecast/306633";

            string text = driver.FindElement(By.ClassName("div.temp-container")).Text;
            
        
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

     
    }
        
}