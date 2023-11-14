using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;

namespace selenium1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            
            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.SendKeys("Java");
            IWebElement ele1 = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]"));
            ele1.Click();
            driver.Close();
        }
    }
}
