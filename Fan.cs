using OpenQA.Selenium;

namespace _4Fans
{
    public class Fan
    {
        public static string googleaccount()
        {
            string message = "";
            string FanMessage = "";

        
        try {

                var LoginasFan = Driver.Instance.FindElement(By.CssSelector("#root .prelanding__bottom__card a button"));
                LoginasFan.Click();

                // Log in by google account

                var JoinwGoogle = Driver.Instance.FindElement(By.XPath("//*[@id=\"root\"]//div[2]/button"));
                JoinwGoogle.Click();

                // Choose email addres

                var SelectMail = Driver.Instance.FindElement(By.CssSelector("#view_container .WEQkZc .d2laFc .WBW9sf.xh-highlight"));
                SelectMail.Click();





            catch (Exception e) {

                message += "ERROR !!!" + e.Message;
            
           }
            message += FanMessage;
            return message;

            }

    }
}