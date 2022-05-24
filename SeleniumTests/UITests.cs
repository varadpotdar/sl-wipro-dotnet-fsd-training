using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
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

        [Test]
        public void SLTest()
        {
            driver.Navigate().GoToUrl("https://www.simplilearn.com/");
            
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(
                 d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

            var searchBox = driver.FindElement(By.Id("header_srch"));
            Assert.That(searchBox, Is.Not.Null);
            
            searchBox.SendKeys("ASP.NET");
            var searchButton = driver.FindElement(By.ClassName("input-search-btn"));
            searchButton.Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(
               d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

            var footerText = driver.FindElement(By.XPath("//footer[@id='footer']"));
            Assert.That(footerText, Is.Not.Null);

            var pageTitleExists = driver.PageSource.Contains("Search Simplilearn Online Courses - #1 Certification Bootcamp");
            Assert.That(pageTitleExists, Is.True);
        }

        [Test]
        public void CheckDeadLinks()
        {
            driver.Navigate().GoToUrl("https://www.simplilearn.com/become-our-trainer");
            Thread.Sleep(2000);

            IList<IWebElement> links = driver.FindElements(By.TagName("a"));
            foreach (IWebElement link in links)
            {
                var url = link.GetAttribute("href");
                IsLinkWorking(url);
            }
        }

        private void IsLinkWorking(string url)
        {
            //if working
            Console.WriteLine("Working");

            //if not working
            Console.WriteLine("Not working");
        }
    }
}