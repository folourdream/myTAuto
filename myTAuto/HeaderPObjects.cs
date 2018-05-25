using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using myTAuto;

namespace myTAuto

{
    public class HeaderPObjects
    {



        protected IWebElement UsernameTxtBox { get; set; }
        protected IWebElement nextBtn { get; set; }


        public void enterUserName(string emailId)
        {

            UsernameTxtBox.SendKeys("pethe.ranjeet@gmail.com");
            nextBtn.Click();

        }





    }
}