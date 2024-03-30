//using OpenQA.Selenium;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using WebDriverProvider.Enums;
//using WebDriverProvider.Interfaces;
//using WebDriverManager;
//using WebDriverManager.DriverConfigs.Impl;
//using OpenQA.Selenium.Remote;

//namespace WebDriverProvider.Classes;
//public partial class WebDriverFactory
//{
//    private void SetupTimeouts()
//    {
//        _webDriver.Manage().Timeouts().PageLoad = _configuration.PageLoad;
//        _webDriver.Manage().Timeouts().ImplicitWait = _configuration.ImplicitWait;
//    }

//    public IWebDriver GetInstanceOf()
//    {
//        return _webDriver;
//    }
//    public void NavigateToBaseUrl()
//    {
//        _webDriver.Navigate().GoToUrl(_configuration.BaseUrl);
//    }

//    public void NavigateToUrl(string url)
//    {
//        if (string.IsNullOrWhiteSpace(url))
//            throw new ArgumentException($"'{nameof(url)}' cannot be null or whitespace.", nameof(url));

//        _webDriver.Navigate().GoToUrl(url);
//    }

//    public string GetCurrentUrl()
//    {
//        var url = _webDriver.Url;

//        return url;
//    }

//    public string GetCurrentTitle()
//    {
//        var title = _webDriver.Title;

//        return title;
//    }

//    public void SwitchToFirstTab()
//    {
//        var firstTab = _webDriver.WindowHandles.First();

//        _webDriver.SwitchTo().Window(firstTab);
//    }

//    public void SwitchToLastTab()
//    {
//        var lastTab = _webDriver.WindowHandles.Last();

//        _webDriver.SwitchTo().Window(lastTab);
//    }

//    public void CloseTab()
//    {
//        _webDriver.Close();
//    }

//    public void TerminateWebDriver()
//    {
//        _webDriver.Close();
//        _webDriver.Quit();
//        _webDriver.Dispose();
//    }
//}
