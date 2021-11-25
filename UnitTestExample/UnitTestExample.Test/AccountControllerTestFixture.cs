using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitTestExample.Controllers;
using Assert = NUnit.Framework.Assert;

namespace UnitTestExample.Test
{
    class AccountControllerTestFixture
    {
        [
            Test,
                TestCase("irf@uni-corvinus.hu", "Abcd1234"),
                TestCase("irf@uni-corvinus.hu", "Abcd1234567"),
        ]
        public void TestRegisterHappyPath(string email, string password)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.Register(email, password);

            // Assert
            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
        }

        [
            Test,
                TestCase("abcd1234", false),
                TestCase("irf@uni-corvinus", false),
                TestCase("irf.uni-corvinus.hu", false),
                TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [
            Test,
                TestCase("abcDEF", false),
                TestCase("DEF123", false),
                TestCase("abc123", false),
                TestCase("aD1", false),
                TestCase("abcDEF123", true)
         ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [
            Test,
                TestCase("irf@uni-corvinus", "Abcd1234"),
                TestCase("irf.uni-corvinus.hu", "Abcd1234"),
                TestCase("irf@uni-corvinus.hu", "abcd1234"),
                TestCase("irf@uni-corvinus.hu", "ABCD1234"),
                TestCase("irf@uni-corvinus.hu", "abcdABCD"),
                TestCase("irf@uni-corvinus.hu", "Ab1234"),
        ]
        public void TestRegisterValidateException(string email, string password)
        {
            var accountController = new AccountController();

            try
            {
                var actualResult = accountController.Register(email, password);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ValidationException>(ex);
            }
        }
    }
}