﻿using System;
using ATeam.Helpers;
using ATeam.Pages;
using ATeam.Pages.Registration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace ATeam.Tests
{
    [TestClass]
    public class IndividualDetailsTest :BaseTest
    {
        [TestMethod]
        public void IndividualDetailsTestMethod()
        {
            this.LoginToRegistrationList(Properties.Settings.Default.UserAteam1, Properties.Settings.Default.PasswordAteam1);
            var regList = new RegistrationList(this.driver);
            regList.RegistrationLink.Click();
            Thread.Sleep(1000);
            regList.GoToIndividualDetailsOfRecord(1);
            var indDetails = new IndividualDetails(this.driver);
            Assert.IsFalse(indDetails.AttributeConfirmed.Selected);
            indDetails.AttributeConfirmed.Click();
            this.driver.AlertHandling();
            Thread.Sleep(500);
            Assert.IsTrue(indDetails.AttributeConfirmed.Selected);
        }

        private void LoginToRegistrationList(string user, string password)
        {
            var landing = new LandingPage(this.driver, true);
            var login = new Login(this.driver);
            login.LogIntoServie(user, password);
        }
    }
}
