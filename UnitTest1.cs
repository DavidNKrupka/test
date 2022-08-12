using Microsoft.Playwright;

namespace test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        
        //playwright
        using var playwright = await Playwright.CreateAsync();
        //browser
        await using var browser = await playwright.Chromium.LaunchAsync();
        //page
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://www.sekologistics.com/us/");
    }
}