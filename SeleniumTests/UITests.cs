using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestFixture]
    public class UITests
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            // Local Selenium WebDriver
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void GotoUrl()
        {
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
        }

        [TearDown]
        public void close_Browser()
        {
            //driver.Quit();
        }
    }
}