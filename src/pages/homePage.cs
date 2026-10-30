using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V152.Runtime;
using sandroCodeflow.src.tests;
using System;

namespace sandroCodeflow.src.pages;

public class HomePage {   

    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
    }
    private IWebDriver driver;

    public string homePageUrl = "https://opensourcedesign.net/";
    public string PageTitle => driver.Title;
    private IWebElement SearchBar => driver.FindElement(By.XPath("//*[@id='osd-search-dialog']/div/form/input"));

    //Array for elements that are found in the search results
    private IReadOnlyCollection<IWebElement> SearchResults => driver.FindElements(By.ClassName("osd-search__result-excerpt"));

    //Locator for search button
    private IWebElement MagnifyingGlass => driver.FindElement(By.XPath("//*[@title='Search (Ctrl/⌘ K)']"));
    
    //Locator for content of the search results
    private IWebElement SearchResultsContent => driver.FindElement(By.XPath("//div[@class='osd-search__panel']//p"));

    //Function to perform a search on the home page
    public void Search(string searchText)
    {
        MagnifyingGlass.Click();
        SearchBar.SendKeys(searchText);

        Thread.Sleep(2000);

        if (SearchResultsContent.Text == $"No results found for {searchText}")
        {
            Console.WriteLine("Search didn't return any results");
        }

    }

    //Function to get the results of the search
    public string[] GetSearchResults()
    { 

        if (SearchResults.Count > 0)
        {
            return SearchResults.Select(el => el.Text).ToArray();
        }
        else
        {
            return Array.Empty<string>();
        }
  
    }

}