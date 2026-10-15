using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using sandroCodeflow.src.pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace sandroCodeflow.src.tests;

[TestClass]
public class HomePageTests
{
    private IWebDriver? driver;

    //Open browser
    public void openChrome()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless=new"); // 👈 Essencial para rodar no Codespaces/Linux
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-dev-shm-usage");

        driver = new ChromeDriver(options);        
    }

    [TestMethod]
    public void searchTest(string text)
    {
        //Go to website
        driver!.Navigate().GoToUrl("https://opensourcedesign.net/");

        //Calls homePage.cs
        HomePage page = new HomePage(driver);
        //Search for something
        text = "Design";
        page.search(text);
    }

}