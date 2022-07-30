using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using BDDproject.Utilities;
using OpenQA.Selenium;

namespace BDDproject.CommonObjectMethod
{
    public class CommonMethod
    {
        public void OpenTideURL()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);

        }
        public void Register()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();
            Thread.Sleep(1000);
        }
        public void SignUP()
        {
            BaseClass.driver.FindElement(By.XPath("//a[text()='Sign up now']")).Click();
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//input[@name='firstName']")).SendKeys("RAkhi");
            BaseClass.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("rakhi.ag991@gmail.com");
            BaseClass.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Abcde@12345");            
        }                                                          
        public void ClickOnCreateAccount()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
        }



        public void OpenTideURL1()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);


        }
        public void OpenLoginPage()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();
            Thread.Sleep(1000);

            BaseClass.driver.FindElement(By.XPath("//*[@id='scroll']/div/div/div/div/div[2]/form/div[7]/div/button"));

            BaseClass.driver.Navigate().GoToUrl("https://www.pggoodeveryday.com/login/");
            BaseClass.driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }
        public void EnterInformation()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@name='signInEmailAddress']")).SendKeys("rakhi.ag991@gmail.com");

            BaseClass.driver.FindElement(By.XPath("//input[@name='currentPassword']")).SendKeys("Abcde@12345");
        }

        public void ClickOnLogin()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@value='LOG IN']")).Click();
            Thread.Sleep(2000);
        }

        public void Url()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);

        }
        public void ClickOnWashClothes()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@data-action-detail='How to Wash Clothes']")).Click();

        }
        public void FindStainRemoval()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us/shop/special-needs/stain-removal");
            BaseClass.driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        public void Url2()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }
        public void ClickOnLocation()
        {
            BaseClass.driver.FindElement(By.XPath("//button[text()='US - English']")).Click();
        }


        public void Url3()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);

        }

        public void ClickOnShopProduct()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/shop']")).Click();
        }
        public void FindProductByRating()
        {
            BaseClass.driver.FindElement(By.XPath("//select[@aria-label='Sort products by']")).Click();
        }
        public void SelectProductRating()
        {
            BaseClass.driver.FindElement(By.XPath("//option[@value='title_az']")).Click();
        }

        public void Url4()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);

        }
        public void ContactUs()
        {
            BaseClass.driver.FindElement(By.XPath("//a[text()='Contact Us']")).Click();
            Thread.Sleep(1000);
        }

        public void Url5()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }
        public void SearchProduct()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@aria-label='Search']")).SendKeys("Product");

            BaseClass.driver.FindElement(By.XPath("//button[@aria-label='Sumbit Search']")).Click();

        }

        public void Url6()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }
        public void OpenLiveChat()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/live-chat']")).Click();
        }

        public void Site()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }
        public void FindNewProducts()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/latest-news']")).Click();
        }
        public void SearchArticleSection()
        {
            BaseClass.driver.FindElement(By.XPath("//span[@aria-label='Link to Latest Articles section']")).Click();
        }

        public void TideUrl3()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/em-us");
            Thread.Sleep(1000);
        }

        public void OpenCouponAndRewards()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/coupons-and-rewards']")).Click();
        }
        public void Save()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='https://www.pggoodeveryday.com/signup/tide-coupons/']")).Click();
        }
        public void LoginAccount()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@name='firstName']")).SendKeys("RAkhi");
            
            BaseClass.driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("rakhi.ag991@gmail.com");
            
            BaseClass.driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Abcde@12345");
           
            BaseClass.driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
            
            Thread.Sleep(2000);
        }
    } 
}
