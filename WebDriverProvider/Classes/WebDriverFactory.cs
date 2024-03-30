using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverProvider.Enums;
using WebDriverProvider.Interfaces;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Remote;
using WebDriverProvider.Configurations;

namespace WebDriverProvider.Classes;
public partial class WebDriverFactory
{
    private readonly IWebDriverConfiguration _configuration;
    private readonly IWebDriver _webDriver;

    public IWebDriverConfiguration Configuration => _configuration;

    public WebDriverFactory(IWebDriverConfiguration configuration)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        _webDriver = InstantiateWebDriver();
        InitializeWebDriver(_webDriver);
    }

    private IWebDriver InstantiateWebDriver()
    {
        IBrowserOptionsConfigurator optionsConfigurator = _configuration.Browser switch
        {
            Browser.Chrome => new ChromeOptionsConfigurator(),
            Browser.Firefox => new FirefoxOptionsConfigurator(),
            Browser.Edge => new EdgeOptionsConfigurator(),
            _ => throw new NotSupportedException($"The browser {_configuration.Browser} is not supported."),
        };

        var options = optionsConfigurator.ConfigureOptions(_configuration.IsHeadless);
        if(_configuration.IsRemote)
        {
            return InstantiateRemoteWebDriver(options, _configuration.SeleniumGridUrl);
        }
        return InstantiateLocalWebDriver(options);
    }

    private IWebDriver InstantiateRemoteWebDriver(DriverOptions options, string seleniumGridUrl)
    {
        var uri = new Uri(seleniumGridUrl);
        return new RemoteWebDriver(uri, options.ToCapabilities());
    }

    private IWebDriver InstantiateLocalWebDriver(DriverOptions options)
    {
        switch (options)
        {
            case ChromeOptions chromeOptions:
                new DriverManager().SetUpDriver(new ChromeConfig());
                return new ChromeDriver(chromeOptions);
            case FirefoxOptions firefoxOptions:
                new DriverManager().SetUpDriver(new FirefoxConfig());
                return new FirefoxDriver(firefoxOptions);
            case EdgeOptions edgeOptions:
                new DriverManager().SetUpDriver(new EdgeConfig());
                return new EdgeDriver(edgeOptions);
            default:
                throw new NotSupportedException("Unsupported browser options type.");
        }
    }

    private void InitializeWebDriver(IWebDriver webDriver)
    {
        webDriver.Manage().Window.Maximize();
        webDriver.Manage().Cookies.DeleteAllCookies();
        SetupTimeouts();
    }
}
