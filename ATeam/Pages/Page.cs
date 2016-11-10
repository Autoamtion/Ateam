﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;

namespace ATeam.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public abstract class Page
    {
        protected IWebDriver driver;

        public Page(IWebDriver webdriver)
        {
            this.driver = webdriver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "img[src='/media/logo.png']")]
        public IWebElement PgsLogo { get; set; }

        public string VisibleText
        {
            get
            {
                var body = this.driver.FindElement(By.TagName("body"));
                return body.Text;
            }
        }
    }
}
