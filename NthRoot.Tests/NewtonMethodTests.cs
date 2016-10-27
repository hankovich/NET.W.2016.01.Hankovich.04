using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NthRoot.Tests
{
    [TestClass]
    public class NewtonMethodTests
    {
        [TestMethod]
        public void NthRoot_sqrt2_Eps6Returned()
        {
            //A
            var expected = 1.4142;
            //A
            var actual = NewtonMethod.NthRoot(2, 2, 4);

            //A
            Debug.WriteLine(expected - actual);
            Assert.IsTrue(condition: Math.Abs(expected - actual) < Math.Pow(10, -4));
        }

        [TestMethod]
        public void NthRoot_3thminus1000_Eps15Returned()
        {
            //A
            double expected = -10;
            //A
            var actual = NewtonMethod.NthRoot(-1000, 3, 15);

            //A

            Debug.WriteLine(expected - actual);
            Assert.IsTrue(condition: Math.Abs(expected - actual) < Math.Pow(10, -15));
        }

        [TestMethod]
        public void NthRoot_maxvalue_Eps15Returned()
        {
            //A
            var expected = Math.Pow(double.MaxValue, 0.01);
            //A
            var actual = NewtonMethod.NthRoot(double.MaxValue, 100, 15);

            //A

            Debug.WriteLine(expected - actual);
            Assert.IsTrue(condition: Math.Abs(expected - actual) < Math.Pow(10, -15));
        }

        [TestMethod]
        public void NthRoot_3rdrootminus3_exceptionReturned()
        {
            var actual = NewtonMethod.NthRoot(-125, 3, 6);
            double expected = -5;

            Debug.WriteLine(expected - actual);
            Assert.IsTrue(condition: Math.Abs(expected - actual) < Math.Pow(10, -6));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NthRoot_zero_zeroReturned()
        {
            var actual = NewtonMethod.NthRoot(0, 2, 15);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NthRoot_sqrtminus2_exceptionReturned()
        {
            var actual = NewtonMethod.NthRoot(-2, 2, 6);
        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NthRoot_sqrt2epsMinus1000_exceptionReturned()
        {
            var actual = NewtonMethod.NthRoot(2, 2, -100);
            
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NthRoot_sqrt2_sqrt2AccuracyEps16Returned()
        {
           var actual = NewtonMethod.NthRoot(2, 2, 16);
        }
    }
}
