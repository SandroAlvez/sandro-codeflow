using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using sandroCodeflow.src.pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace sandroCodeflow.src.tests;

[TestClass]
public class HomePageTests : TestBase
{


    [TestMethod]
    public void AccessHomePage()
    {
        HomePage homePage = new HomePage(driver);
        //Go to website
        driver.Navigate().GoToUrl(homePage.homePageUrl);
        
        //Verify if home page is loaded
        Assert.AreEqual("Open Source Design", homePage.pageTitle);

        //Calls homePage.cs
            //HomePage page = new HomePage(driver);
        //Search for something
            // text = "Design";
            // page.search(text);
        
    }

}