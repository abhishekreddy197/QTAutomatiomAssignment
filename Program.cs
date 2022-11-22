using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Assignment02
{
    public class Program
    {
        public static IWebDriver driver = new ChromeDriver();

        static void Main()
        {
            //Console.WriteLine("Hello World!");
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            ExcerciseOne();
            ExerciseTwo();
            ExerciseThree();
            ExcerciseFour();
            ExerciseFourPointOne();
            ExerciseFourPointTwo();
            ExcerciseFive();
            ExcerciseSix();
            ExcerciseSeven();
            ExcerciseEignt();
            ExcerciseNine();

        }

        public static void ExcerciseOne()
        {

            for (int i = 1; i < 4; i++)
            {
                IWebElement radiobutton = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[" + i + "]/input"));
                radiobutton.Click();
                Thread.Sleep(1000);
            }
        }

        public static void ExerciseTwo()
        {
            driver.FindElement(By.Id("autocomplete")).SendKeys("United States");     
            Thread.Sleep(1000);

            //List<IWebElement> options = (List<IWebElement>) driver.FindElement(By.XPath("//*[@class='ui-menu-item']"));

            /*for (int i = 0; i < options.Capacity; i++)                  
            {
                if (options[i].GetAttribute("United States Minor Outlying Islands") == "United States Minor Outlying Islands")
                {
                    options[i].Click();
                    break;
                }

            }*/
        }

        public static void ExerciseThree()
        {
            IWebElement drpDwn = driver.FindElement(By.XPath("//*[@id=\"dropdown-class-example\"]"));

            for (int i = 2; i < 5; i++)
            {
                IWebElement drpDwnOps = driver.FindElement(By.XPath("//*[@id=\"dropdown-class-example\"]/option[" + i + "]"));
                drpDwn.Click();
                Thread.Sleep(500);
                drpDwnOps.Click();
                Thread.Sleep(500);
                drpDwn.Click();
                Thread.Sleep(500);
            }

        }

        public static void ExcerciseFour()
        {

            for (int option = 1; option <= 3; option++)
            {
                IWebElement Checkbox = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + option + "\"]"));

                Checkbox.Click();
                Thread.Sleep(500);

                Checkbox.Click();
                Thread.Sleep(500);

            }

        }


        public static void ExerciseFourPointOne()
        {
            for (int i = 1; i <= 3; i++)
            {
                IWebElement Checkall = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + i + "\"]"));
                Checkall.Click();
                Thread.Sleep(1000);
            }
        }



        public static void ExerciseFourPointTwo()
        {
            for (int i = 1; i <= 3; i++)
            {
                IWebElement deselect = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption" + i + "\"]"));
                deselect.Click();
                Thread.Sleep(500);
            }

        }


        public static void ExcerciseFive()
        {
            IWebElement data = driver.FindElement(By.XPath("//*[@id=\"openwindow\"]"));
            data.Click();
            Thread.Sleep(1000);
            //Window(driver.WindowHandles[1]).Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public static void ExcerciseSix()
        {
            IWebElement opentabbtn = driver.FindElement(By.Id("opentab"));
            opentabbtn.Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(1000);


        }

        public static void ExcerciseSeven()
        {

            IWebElement altxt = driver.FindElement(By.Id("opentab"));
            altxt.SendKeys("Qualitest");
            Thread.Sleep(1000);

            IWebElement altbtn = driver.FindElement(By.Id("alertbtn"));
            altbtn.Click();
            Thread.Sleep(1000);
            var alt = driver.SwitchTo().Alert();
            alt.Accept();

        }

        public static void ExcerciseEignt()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;                 
            Thread.Sleep(500);
            jse.ExecuteScript("window.scrollBy(0,600)");          
            Thread.Sleep(1500);
            jse.ExecuteScript("document.querySelector('.tableFixHead').scrollBy(0,6000)");   
            Thread.Sleep(1000);

        }

        public static void ExcerciseNine()
        {
            Actions a = new Actions(driver);
            IWebElement mousehower = driver.FindElement(By.XPath("//*[@id=\"mousehover\"]"));          
            a.MoveToElement(mousehower).Click().Build().Perform();      
            Thread.Sleep(5000);

            IWebElement mouseclick = driver.FindElement(By.XPath("/html/body/div[4]/div/fieldset/div/div/a[1]"));
            a.MoveToElement(mouseclick).Click().Build().Perform();
            Thread.Sleep(5000);
            
        }



    } 
}

