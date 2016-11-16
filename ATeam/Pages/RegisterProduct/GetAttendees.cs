﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ATeam.Pages.RegisterProduct
{
    using ATeam.Helpers;
    using ATeam.Objects;

    public class GetAttendees : Page
    {
        public GetAttendees(IWebDriver webdriver) : base(webdriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "input[name='name']")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.Name, Using = "surname")]
        public IWebElement Surname { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "phone")]
        public IWebElement Phone { get; set; }

        [FindsBy(How = How.Name, Using = "product")]
        public IList<IWebElement> Product { get; set; }

        [FindsBy(How = How.Id, Using = "RegistrationLanguageID7")]
        public IWebElement ProductLanguageEnglish { get; set; }

        [FindsBy(How = How.Id, Using = "RegistrationLanguageID8")]
        public IWebElement ProductLanguagePolish { get; set; }

        [FindsBy(How = How.Id, Using = "ProductFormIdpapierowa")]
        public IWebElement ProductFormPaper { get; set; }

        [FindsBy(How = How.Id, Using = "ProductFormIdelektroniczna")]
        public IWebElement ProductFormElectronic { get; set; }

        [FindsBy(How = How.Name, Using = "certificateNumber")]
        public IWebElement CertificateNumber { get; set; }

        [FindsBy(How = How.Name, Using = "certificatePicker")]
        public IWebElement CertificateDate { get; set; }

        [FindsBy(How = How.Name, Using = "certificateProvider")]
        public IWebElement CertificateProvider { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        public IWebElement AddUserToList { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class='Register-forwardBtn'] > button")]
        public IWebElement Forward { get; set; }

        public void Populate(Attendee att)
        {
            this.Name.SendKeys(att.Name);
            this.Surname.SendKeys(att.SurName);
            this.Email.SendKeys(att.Email);
            if (att.FillPhone)
            {
                this.Phone.SendKeys(att.PhoneNumber);
            }

            this.Product[att.SelectedProductId].Click();
            this.driver.WaitForAjax();
            this.ProductLanguagePolish.WaitForElement(500);

            if (att.IsEnglish)
            {
                this.ProductLanguageEnglish.Click();
            }
            else
            {
                this.ProductLanguagePolish.Click();
            }

            if (att.IsPaperExam)
            {
                this.ProductFormPaper.Click();
            }
            else
            {
                this.ProductFormElectronic.Click();
            }

            if (this.CertificateNumber.Exists())
            {
                this.CertificateNumber.SendKeys(att.CertificateNumber);
                this.CertificateDate.SendKeys(att.CertificateIssueDate);
                this.CertificateProvider.SendKeys(att.CertificateIssuer);
            }
        }
    }
}
