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
    public class ControllersValodationTest
    {
        [TestMethod()]
        public void IsLineNumbers()
        {
            // arange
            string line1 = "0123456789";
            string line2 = "89o7";
            string line3 = "f12";
            string line4 = "2r";
            // act
            bool answerd1 = ControllerValidation.IsLineNumbers(line1);
            bool answerd2 = ControllerValidation.IsLineNumbers(line2, line1);
            bool answerd3 = ControllerValidation.IsLineNumbers(line3);
            bool answerd4 = ControllerValidation.IsLineNumbers(line4);
            // assert
            Assert.IsTrue(answerd1);
            Assert.IsFalse(answerd2);
            Assert.IsFalse(answerd3);
            Assert.IsFalse(answerd4);
        }

        [TestMethod()]
        public void IsValidationLineLetter()
        {
            // arange
            string line1 = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string line2 = "1Dsa";
            string line3 = "L0L";
            string line4 = "kilokmmkl9";
            // act
            bool answerd1 = ControllerValidation.IsValidationLineLetter(line1);
            bool answerd2 = ControllerValidation.IsValidationLineLetter(line1, line2);
            bool answerd3 = ControllerValidation.IsValidationLineLetter(line3, line1);
            bool answerd4 = ControllerValidation.IsValidationLineLetter(line4);
            // assert
            Assert.IsTrue(answerd1);
            Assert.IsFalse(answerd2);
            Assert.IsFalse(answerd3);
            Assert.IsFalse(answerd4);
        }

        [TestMethod()]
        public void IsValidationNullStringTest()
        {
            // arange
            string line1 = "";
            string line2 = default;
            string line3 = " ";
            string line4 = "asn";
            // act
            bool answerd1 = ControllerValidation.IsValidationNullString(line1);
            bool answerd2 = ControllerValidation.IsValidationNullString(line2);
            bool answerd3 = ControllerValidation.IsValidationNullString(line1, line2);
            bool answerd4 = ControllerValidation.IsValidationNullString(line3);
            bool answerd5 = ControllerValidation.IsValidationNullString(line4);
            bool answerd6 = ControllerValidation.IsValidationNullString(line4, line3);
            // assert
            Assert.IsFalse(answerd1);
            Assert.IsFalse(answerd2);
            Assert.IsFalse(answerd3);
            Assert.IsFalse(answerd4);
            Assert.IsTrue(answerd5);
            Assert.IsFalse(answerd6);
        }
    }
}