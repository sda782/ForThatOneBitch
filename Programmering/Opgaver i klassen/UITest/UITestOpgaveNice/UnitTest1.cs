using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace UITestOpgaveNice
{
    [TestClass]
    public class UnitTest1
    {

        private static readonly string DriverDirectory = "C:\\WebDrivers";
        private static IWebDriver _driver;


        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory); // fast
            // _driver = new FirefoxDriver(DriverDirectory);  // slow
            // _driver = new EdgeDriver(DriverDirectory); // times out ... not working
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();
        }


        [TestMethod]
        public void TestMethod1()
        {
            _driver.Navigate().GoToUrl("file:///C:/Users/Oliver/Desktop/Skole/3%20Semester/Programmering/Opgaver%20i%20klassen/UITestOpgave/index.html");
            //_driver.Navigate().GoToUrl("file:///C:/andersb/javascript/calculator/index.htm");
            Assert.AreEqual("CalculatorApp", _driver.Title);

            IWebElement inputElement1 = _driver.FindElement(By.Id("num1"));
            inputElement1.SendKeys("10");

            IWebElement inputElement2 = _driver.FindElement(By.Id("num2"));
            inputElement2.SendKeys("15");

            IWebElement buttonElement = _driver.FindElement(By.Id("calculateBtn"));
            buttonElement.Click();

            IWebElement outputElement = _driver.FindElement(By.Id("result"));
            string text = outputElement.Text;

            Assert.AreEqual("25", text);
        }
    }
}
