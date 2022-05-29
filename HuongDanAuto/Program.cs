using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace HuongDanAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"user-data-dir=C:\Users\TuanTran\source\repos\HuongDanAuto\HuongDanAuto\profile\facebook");
            options.AddArgument("--app=https://www.facebook.com/le.anh.tuan388");

            ChromeDriver chromeDriver = new ChromeDriver(options);
            
            //chromeDriver.ExecuteScript("window.scrollBy(0, 1000);");
            //Thread.Sleep(1000);
            //chromeDriver.ExecuteScript("window.scrollBy(0, 1000);");
            //Thread.Sleep(1000);
            //chromeDriver.ExecuteScript("window.scrollBy(0, 1000);");
            //Thread.Sleep(1000);
            var elements = chromeDriver.FindElements(By.CssSelector("div[aria-label='Like'][role='button']"));
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
            Actions action = new Actions(chromeDriver);
            action.MoveToElement(elements[0]).Perform();
            Thread.Sleep(1000);
            chromeDriver.FindElements(By.CssSelector("div[style*='39']"))[1].Click();

        }
    }
}
