using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Fans


{
    [TestClass]
    public class MainClass
    {

        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }


        [TestMethod]
        public void TestMethod1()

        {
            string subject = "";
            string body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string CreatorMessage = Creator.emailaddress();
          
            string FanMessage = Fan.googleaccount();





            if (!CreatorMessage.Contains("ERROR") & (!FanMessage.Contains("ERORR")))

        {
            subject = "Passed!!! " + subject;
            body = "Test je prošao" + "\n" + CreatorMessage + FanMessage;  
        }
        
        else
        
        {
            subject = "Failed!!! " + subject;
            body = CreatorMessage + FanMessage;
        }




            Assert.IsTrue(subject.Contains("Passed"));
            Assert.IsFalse(subject.Contains("Failed"));

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}