using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace sandroCodeflow.src.tests;


public class TestBase
{
    public IWebDriver driver;

    [TestInitialize]
    public void setup()
    {
        driver = new ChromeDriver();
    }

    [TestCleanup]
    public void tearDown()
    {
        driver.Quit();
    }
}