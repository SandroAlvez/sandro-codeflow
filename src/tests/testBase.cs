using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace sandroCodeflow.src.tests;


public class TestBase
{
    public IWebDriver driver;

    [TestInitialize]
    public void SetUp()
    {
        driver = new ChromeDriver();
    }

   // [TestCleanup]
   /* public void TearDown()
    {
        driver.Quit();
    }*/
}