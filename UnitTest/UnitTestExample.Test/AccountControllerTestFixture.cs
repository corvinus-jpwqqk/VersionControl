﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    class AccountControllerTestFixture
    {
        [Test,
         TestCase("abcd1234", false),
         TestCase("irf@uni-corvinus", false),
         TestCase("irf.uni-corvinus.hu", false),
         TestCase("irf@uni-corvinus.hu", true)]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            AccountController ac = new AccountController();
            var validateResult = ac.ValidateEmail(email);
            Assert.AreEqual(validateResult, expectedResult);
        }
        [Test, 
            TestCase("asd123asd", false), 
            TestCase("ASD123ASD",false), 
            TestCase("asdASDaSd", false), 
            TestCase("aS2", false), 
            TestCase("asdASD123", true)
            ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            AccountController ac = new AccountController();
            var validateResult = ac.ValidatePassword(password);
            Assert.AreEqual(validateResult, expectedResult);
        }
        [
            Test,
            TestCase("irf@uni-corvinus.hu", "Abcd1234"),
            TestCase("irf@uni-corvinus.hu", "Abcd1234567"),
        ]
        public void TestRegisterHappyPath(string email, string password)
        {
            AccountController ac = new AccountController();
            var result = ac.Register(email, password);
            Assert.AreEqual(result.Password, password);
            Assert.AreEqual(result.Email, email);
            Assert.AreNotEqual(result.ID, Guid.Empty);
        }
    }
}
