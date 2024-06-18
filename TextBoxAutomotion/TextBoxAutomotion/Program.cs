

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

IWebDriver driver = new FirefoxDriver();
            // Your automation code goes here



 driver.Url = "https://demoqa.com/automation-practice-form";






var firstName = driver.FindElement(By.Id("firstName"));
firstName.SendKeys("MD TAMIZ");

var lastName = driver.FindElement(By.Id("lastName"));
lastName.SendKeys("UDDIN");


var userEmail = driver.FindElement(By.Id("userEmail"));
userEmail.SendKeys("abc@email.com");

//var genderMale = driver.FindElement(By.ClassName("custom-control-input"));
//genderMale.Click();


IWebElement radioButton = driver.FindElement(By.Id("gender-radio-2"));
IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
js.ExecuteScript("arguments[0].click();", radioButton);


var userNumber = driver.FindElement(By.Id("userNumber"));
userNumber.SendKeys("1234567890");


var dateOfBirthInput = driver.FindElement(By.Id("dateOfBirthInput"));
dateOfBirthInput.SendKeys("10/05/1999");


var subjectsContainer = driver.FindElement(By.Id("subjectsContainer"));
subjectsContainer.SendKeys("Mathematics");

var hobbiesCheckbox = driver.FindElement(By.Id("hobbies-checkbox-1"));
hobbiesCheckbox.Click();



//var uploadPicture = driver.FindElement(By.Id("uploadPicture"));
//uploadPicture.SendKeys("C:\\Users\\This pc\\Pictures.jpg");


var currentAddress = driver.FindElement(By.Id("currentAddress"));
currentAddress.SendKeys("Dhaka");


//IWebElement objSelect = new IWebElement(driver.FindElement(By.Id("state")));
//objSelect.SelectByText("Haryana");

//IWebElement objSelectCity = new IWebElement(driver.FindElement(By.Id("state")));
//objSelectCity.SelectByText("Karnal");


////var submitForm = driver.FindElement(By.Id("submit"));

////submitForm.Click();



