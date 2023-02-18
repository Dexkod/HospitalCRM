using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Tests
{
    [TestClass()]
    public class ControllersPasswordTests
    {
        [TestMethod()]
        public void PasswordAndPasswordEncryption()
        {
            // arrange
            string password = "0000";
            // act
            string passwordEncryption = ControllerPassword.PasswordEncryption(password);
            string actaulPassword = ControllerPassword.PasswordDecoding(passwordEncryption);
            // assert
            Assert.AreEqual(password, actaulPassword);
            Assert.AreNotEqual(password, passwordEncryption);
        }
    }
}