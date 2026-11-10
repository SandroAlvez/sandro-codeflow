using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace sandroCodeflow.src.pages;

public class HomePage {   

    //Private field for the WebDriver instance
    private IWebDriver driver;

    //Explicit wait
    private WebDriverWait wait;

    //Constructor for the HomePage class
    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        
    }
  

    //URL for the home page
    public string homePageUrl = "https://opensourcedesign.net/";

    //Property to get the title of the page
    public string PageTitle => driver.Title;

    //Locator for the search bar
    private IWebElement SearchBar => driver.FindElement(By.XPath("//*[@id='osd-search-dialog']/div/form/input"));

    //Array for elements that are found in the search results
    private IReadOnlyCollection<IWebElement> ListOfSearchResults => driver.FindElements(By.Id("osd-search-results"));

    //Locator for search button
    private IWebElement MagnifyingGlass => driver.FindElement(By.XPath("//*[@title='Search (Ctrl/⌘ K)']"));
    
    //Locator for content of the search results
    private IWebElement SearchResultsContent => driver.FindElement(By.XPath("//div[@class='osd-search__panel']//p"));

    //Function to perform a search on the home page
    public void Search(string searchText)
    {

        wait.Until(driver => MagnifyingGlass.Displayed);
        MagnifyingGlass.Click();
        if (SearchBar.Displayed)
        {
            SearchBar.SendKeys(searchText);
        }
        else
        {
            Console.WriteLine("MagnifyingGlass locator didn't find any elements");
        }
               

    }

    //Function to get the search results
    public IReadOnlyCollection<IWebElement> GetSearchResultsElements()
    { 
        //Wait for the search results to load
        wait.Until(driver => SearchResultsContent.Displayed);
        if (ListOfSearchResults.Count > 0)
        {
            return ListOfSearchResults;
        }
        else
        {
            Console.WriteLine("SearchResultsElements locator didn't find any elements");
            return ListOfSearchResults;
            
        }
  
    }

}