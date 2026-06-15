using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace appiumtests;

public class AndroidBasicTest
{
    private AppiumDriver driver;

    [SetUp]
    public void Setup()
    {
        var options = new AppiumOptions
        {
            PlatformName = "Android",
            AutomationName = "UiAutomator2",
            DeviceName = "Pixel 10 API 34"
        };

        options.AddAdditionalAppiumOption("appPackage", "com.android.settings");
        options.AddAdditionalAppiumOption("appActivity", ".Settings");
        options.AddAdditionalAppiumOption("noReset", true);

        driver = new AndroidDriver(
            new Uri("http://127.0.0.1:4723"),
            options
        );
    }

    [Test]
    public void OpenSettings()
    {
        Assert.That(driver.SessionId, Is.Not.Null);
        Console.WriteLine("Android test");
    }

    [TearDown]
    public void TearDown()
    {
        driver?.Quit();
        driver?.Dispose();
    }
}