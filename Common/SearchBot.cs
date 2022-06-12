using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
namespace CrawlApi.Common
{
    public class SearchBot
    {
        
        public void GetHtml()
        {
            System.Console.WriteLine("Search Done!");

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");//tắt tính năng phát hiện bot của navigator.webdriver
            options.AddAdditionalCapability("useAutomationExtension", false);//Xóa thông báo trình duyệt được điều khiển bởi selenium
            options.AddExcludedArgument("enable-automation");
            options.AddArguments("--disable-notifications"); // to disable notification
            options.AddArgument("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:90.0) Gecko/20100101 Firefox/90.0");
            // options.AddExtension(ConfigurationManager.AppSettings["ExtensionPath"]); //Extension Scroll page
            //options.AddArgument("headless");// không bật trình duyệt
            //options.AddArguments("--auto-open-devtools-for-tabs");//open devtool

            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.SuppressInitialDiagnosticInformation = true;
            ChromeDriver driver = new ChromeDriver(service, options, TimeSpan.FromMinutes(10));

            driver.Navigate().GoToUrl("https://www.google.com.vn/");
        }
    }
}
