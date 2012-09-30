namespace PageMapper.Enums
{
    // Summary:
    //     Provides the lookup methods for the FindsBy attribute (for using in PageObjects)
    public enum How
    {
        // Summary:
        //     Finds by OpenQA.Selenium.By.Id(System.String)
        Id = 0,
        //
        // Summary:
        //     Finds by OpenQA.Selenium.By.Name(System.String)
        Name = 1,
        //
        // Summary:
        //     Finds by OpenQA.Selenium.By.TagName(System.String)
        TagName = 2,
        //
        // Summary:
        //     Finds by OpenQA.Selenium.By.ClassName(System.String)
        ClassName = 3,
        //
        // Summary:
        //     Finds by OpenQA.Selenium.By.CssSelector(System.String)
        //CssSelector = 4,
        //
        // Summary:
        //     Finds by OpenQA.Selenium.By.LinkText(System.String)
        //LinkText = 5,
        //
        // Summary:
        //     Finds by OpenQA.Selenium.By.PartialLinkText(System.String)
        //PartialLinkText = 6,
        //
        // Summary:
        //     Finds by OpenQA.Selenium.By.XPath(System.String)
        //XPath = 7,
    }
}