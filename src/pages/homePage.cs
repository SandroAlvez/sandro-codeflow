using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V152.Runtime;
using sandroCodeflow.src.tests;

namespace sandroCodeflow.src.pages;

public class HomePage {   

    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
    }
    private IWebDriver driver;

    public string homePageUrl = "https://opensourcedesign.net/";
    public string pageTitle => driver.Title;
    private IWebElement searchBar => driver.FindElement(By.XPath("//*[@id='osd-search-dialog']/div/form/input"));


    //Locator for search button
    private IWebElement magnifyingGlass => driver.FindElement(By.XPath("//*[@title='Search']"));
    
    //Array for elements that are found in the search results
    private IWebElement searchResults => driver.FindElement(By.Id("osd-search-results"));


    //Function to get the results of the search
    /*public string[] getSearchResults(IWebElement[] searchResults)
    { 

        //string[] listOfResults = driver.FindElements(By.CssSelector("#osd-search-results li")).Select(el => el.Text).ToArray();
        
        if (searchResults.Length > 0)
        {
            for (int i = 0; i < searchResults.Length; i++)
            {
                listOfResults[i] = searchResults[i].Text;

            }
            return listOfResults;
        }
        else
        {
            listOfResults = new string[1];
            listOfResults[0] = "No results found";
            return listOfResults;
        }

    }*/
    public void search(string searchText)
    {
        magnifyingGlass.Click();
        searchBar.SendKeys(searchText);

    }
}