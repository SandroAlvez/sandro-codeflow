using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using sandroCodeflow.src.pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace sandroCodeflow.src.tests;

[TestClass]
public class HomePageTests : TestBase
{
    private string searchText = "Design";

    [TestMethod]
    public void AccessHomePage()
    {
        //Calls homePage.cs
        HomePage homePage = new HomePage(driver);

        //Go to website
        driver.Navigate().GoToUrl(homePage.homePageUrl);
        
        //Verify if home page is loaded
        Assert.AreEqual("Open Source Design", homePage.PageTitle);

        


        //Make a search
        homePage.Search(searchText); 

                //Get the search results
        string[] searchResults = homePage.GetSearchResults();


        //Verify if the text is found in the search results
        foreach (string result in searchResults)
        {
            Assert.IsTrue(result.Contains(searchText, StringComparison.OrdinalIgnoreCase));
        }
        
    }

    //Mock data for search test   
    //private string searchText = "Design";
    
    /*[TestMethod]
    public void SearchText(string searchText)
    {
        //Calls homePage.cs
        HomePage homePage = new HomePage(driver);

        //Make a search
        homePage.Search(searchText); 

        //Get the search results
        string[] searchResults = homePage.GetSearchResults();

        //Verify if the text is found in the search results
        foreach (string result in searchResults)
        {
            Assert.IsTrue(result.Contains("Design"));
        }
    }*/

}