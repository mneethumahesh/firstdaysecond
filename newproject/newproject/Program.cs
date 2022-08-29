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

//create new time record
//navigate to time and material page

IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationTab.Click();
IWebElement timeOptionButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeOptionButton.Click();


// click on create new
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
createNewButton.Click();


//select 'Time' option from drop down from typecode

IWebElement typeCodeButton = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
typeCodeButton.Click();
IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
timeOption.Click();

//input the code
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("August2022");

//input the description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("August2022");

//input price per unit

IWebElement priceInputtag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
priceInputtag.Click();
IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("336");


//click on save button

IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
saveButton.Click();
Thread.Sleep(5000);


//create if the record is svaed and present in the last page
IWebElement lastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
lastpageButton.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));


if (newCode.Text == "August2022")
{
    Console.WriteLine("Saved successfully");
}
else
{
    Console.WriteLine("New time record has not been created");
}
