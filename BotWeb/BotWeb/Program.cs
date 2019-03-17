using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace BotWeb
{
    class Program
    {

        public static void Main(string[] args)
        {

            IWebDriver _driver;
           
            _driver = new ChromeDriver("C:\\Users\\laast\\.nuget\\packages\\selenium.webdriver.chromedriver\\73.0.3683.68\\driver\\win32");
            _driver.Navigate().GoToUrl("https://reddit.com");      

            IList<IWebElement> titles = _driver.FindElements(By.XPath("//*[@class='s1okktje-0 kCqBrs']")) ;

            foreach (var title in titles)
            {
                Console.WriteLine(title.Text);
                Thread.Sleep(300);
            }
                       
        }
    }
   
}
