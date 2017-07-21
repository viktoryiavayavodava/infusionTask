using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPractice
{
    public class Class1 : BaseTest
    {
        
        public void T01_OpenCareers()

        {
            Driver.Url = "https://www.infusion.com";
            Driver.FindElement(By.CssSelector(".INF-mainMenu_trigger")).Click();
            Driver.FindElement(By.XPath("//a[@href='/#careers']")).Click();
            Driver.FindElement(By.ClassName("cta_button INF-btnOneCorner")).Click();

//finding krakow 4 results

            Driver.FindElements(By.XPath("//article[@id='job-offers'] and contains(text(), \"Krakow\")]"));
            Assert.AreEqual (Driver.FindElements(By.XPath("//article[@id='job-offers'] and contains(text(), \"Krakow\")]/li")).Count(), 4);

//finding warsaw at least 1 result
            Driver.FindElements(By.XPath("//article[@id='job-offers'] and contains(text(), \"Krakow\")]"));
            Assert.AreEqual(Driver.FindElements(By.XPath("//article[@id='job-offers'] and contains(text(), \"Krakow\")]/li")).Count(), 4);
            Assert.GreaterOrEqual(Driver.FindElements(By.XPath("//article[@id='job-offers'] and contains(text(), \"Warsaw\")]/li")).Count(), 1);


//checking offer wording
            Driver.FindElement(By.XPath("//section[@id='find-all-jobs']/input[@class='location']")).Click();
            Driver.FindElement(By.XPath("//*[@id='location_Raleigh']")).Click();
            Driver.FindElement(By.Id ("location_Raleigh")).Click();
            Driver.FindElement(By.LinkText("Software QA Analyst")).Click();
            if
                (Driver.FindElement (By.XPath ("//div/h2 [text() = 'Software QA Analyst']")).Displayed) 
            {
                Driver.FindElement(By.XPath("//*[@id='job-offer-details']//div")).Text.Contains("Experience creating and implementing testing framework for web applications such as Selenium");
            }
          
            else
            {
                throw new Exception();

            }

        }


    }

}
