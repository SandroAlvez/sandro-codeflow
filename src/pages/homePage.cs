using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V152.Runtime;

namespace sandroCodeflow.src.pages;

public class HomePage {   
    private readonly IWebDriver driver;
    private string homePageUrl = "https://opensourcedesign.net/";
    private IWebElement searchBar => driver.FindElement(By.XPath("//*[@id='osd-search-dialog']/div/form/input"));

    public HomePage(IWebDriver testDriver) {
        driver = testDriver;
    }

    IWebElement magnifyingGlass => driver.FindElement(By.XPath("//*[@title='Search']"));

    public void search(string searchText)
    {
        magnifyingGlass.Click();
        searchBar.SendKeys(searchText);

    }
}