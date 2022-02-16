using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        

        [TestMethod()]
        public void PalindromeTest_Input()
        {
            //Arrange
            int input = 131;
            bool expected = true;

            //Act 
            bool  actual = Algebra.IsPalindrome(input); 
            
            //Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}