using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;

namespace appiumtests;

public class IOSBasicTest
{
    private IOSDriver driver;

    [SetUp]
    public void Setup()
    {
        var options = new AppiumOptions
        {
            PlatformName = "iOS",
            AutomationName = "XCUITest",
            DeviceName = "iPhone 17 Pro"
        };

        options.AddAdditionalAppiumOption("appium:udid", "8AAA8079-1031-411D-B42E-2911E84B49AB");
        options.AddAdditionalAppiumOption("appium:bundleId", "com.apple.Preferences");
        options.AddAdditionalAppiumOption("appium:noReset", true);

        driver = new IOSDriver(
            new Uri("http://127.0.0.1:4723/"),
            options
        );
    }

    [Test]
    public void OpenSettings()
    {
        Assert.That(driver.SessionId, Is.Not.Null);
        Console.WriteLine("iOS test");
    }

    [TearDown]
    public void TearDown()
    {
        driver?.Dispose();
    }
}