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

            var en = driver.FindElement(By.Id("js-link-box-en"));
            en.Click();
        }


        [Test]
        public void GoogleSearchExample()
        {
            Console.Write("test case started ");

            // navigate to URL  
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(2000);

            // identify the Google search text box  
            IWebElement searchTextBox = driver.FindElement(By.Name("q"));

            //enter the value in the google search text box  
            searchTextBox.SendKeys("covid cases");
            Thread.Sleep(2000);

            //identify the google search button  
            IWebElement btnIFeelLucky = driver.FindElement(By.Name("btnI"));

            // click on the Google search button  
            btnIFeelLucky.Click();
            Thread.Sleep(3000);

            Console.Write("test case ended ");
        }

        [TearDown]
        public void CloseBrowser()
        {
            //driver.Quit();
        }
    }
}