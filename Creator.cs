using _4Fans;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;

public class Creator
{
    public static string Login()
    {

        string message = "";
        string CreatorMessage = "";
        string url = "https://stage.4fans.com/";
        string username = "Borg1337";
        string password = "pa55word1337";
        string email = "borg1337@gmail.com";


        try
        {
            Driver.Instance.Navigate().GoToUrl(url); // navigiranje na stranicu 4fans
            Thread.Sleep(1000);
           
            // odabrati opciju registracije kao Creator
            var JoinAsCreator = Driver.Instance.FindElement(By.XPath("//*[@id=\"root\"]//div[2]/div[1]/div[1]/a")); 
            JoinAsCreator.Click();
            
            // registrovati se pute emaila
            var JoinEmail = Driver.Instance.FindElement(By.XPath("//*[@id=\"root\"]//div[2]/a/button"));
            JoinEmail.Click();

            var Username = Driver.Instance.FindElement(By.XPath("//*[@id=\"root\"]//div[2]//form/div/div/div[1]/input"));
            Username.Click();
            Username.SendKeys(username);
          

            var Password = Driver.Instance.FindElement(By.CssSelector("#root div:nth-child(3) div:nth-child(2) input"));
            Username.Click();
            Password.SendKeys(password);

            var Email = Driver.Instance.FindElement(By.CssSelector("#root div:nth-child(3) div:nth-child(3) input"));
            Email.Click();
            Email.SendKeys(email);

            var RegButton = Driver.Instance.FindElement(By.CssSelector("#root  div:nth-child(3) button"));
            RegButton.Click();



        }

        catch (Exception e)
        {

            message += "ERROR!!!" + e.Message;

        }

        message += CreatorMessage;
        return message;



    }
}




