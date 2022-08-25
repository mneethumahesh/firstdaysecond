// open chrome browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V102.Target;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//launch turn up portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify username and validate with valid username

IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");


//identify password and validate with valid password

IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");


//identify and click on log in button

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();


// check if the user has logged in correctly

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));


if (helloHari.Text == "Hello hari!") 
{
    Console.WriteLine("logged in successfully,test passed");
}
else
{
    Console.WriteLine("log in failed");
}

//create Time and Material
//create new Time